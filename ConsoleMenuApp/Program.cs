// This application displays menu option to a user
// The user must login with a username (shouldn't be case specific e.g. eLliOt.bEllIngHaM@example.oRG
// The user must login with a password which should be specific
// The Menu will repeat until the user selects an option from the list

//App level variables
string restaurantName = "Nandos";
string username = "";
string password = "";
//While loop to ask for correct login details
bool loggedIn = false;
Console.WriteLine($"Welcome to the {restaurantName} menu app!");
while (loggedIn == false)
{
    //username and password input with a check that something is inputted
    Console.Write("""
                      You will need to login with your username and password.
                      What is your username?
                      Username:  
                      """);
    username = Console.ReadLine().ToLower();
    Console.Write("Password: ");
    password = Console.ReadLine();
    if (username == "" || password == "")
    {
        Console.Clear();
        Console.WriteLine("If you have an account with us something those details aren't correct please try again.\nPress enter to continue.");
        Console.ReadLine();
    }
    else
    {
        loggedIn = true;
    }
    Console.Clear();
}



//While loop to repeat menu
sbyte menuItemChosen = -1;
string menuItemInput = "";
sbyte[] menuListItems = {1,2,3,4,5 };
while (menuItemChosen == -1) 
{
    //handle menu display

    Console.Write($"""
                      Great to see you back {username}!
                      Please select a menu item from today's specials.
                      1.
                      2.
                      3.
                      4.
                      5.
                      Please select by entering a number for the menu item you would like to order.
                      Menu item desired: 
                      """);
    menuItemInput = Console.ReadLine();

    try
    {
        menuItemChosen = Convert.ToSByte(menuItemInput);
    }
    catch (Exception e)
    {
        //Console.WriteLine(e);
        Console.Clear();
        Console.WriteLine("Please don't try to break the rules Sir/Ma'am. This is a Nandos.");
        menuItemChosen = -1;
    }
    
    //check if input is valid
    // valid = number within options
    if (!menuListItems.Contains(menuItemChosen))
    {
        Console.WriteLine("It doesn't seem like you chose an item from our menu. Press enter and we will give you another try.");
        Console.ReadLine();
        Console.Clear();
        menuItemChosen = -1;
    }
    else
        Console.WriteLine($"That's a great choice {username}. We'll serve a number {menuItemChosen} right up to you.");
}

