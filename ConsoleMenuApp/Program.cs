/*
    This application displays menu options to a user
    The user must login with a username (shouldn't be case specific e.g. eLliOt.bEllIngHaM@example.oRG
    The user must login with a password which should be case specific
    The Menu will repeat until the user selects an option from the list
    Users are stored in a dictionary. Databases are to be added later
*/

//App level variables

using ConsoleMenuApp;
using ConsoleMenuApp.Enumerations;

string restaurantName = "Nandos";
string username = "";
string password = "";


//Users are now stored in the User object
User users = new User();

//While loop to ask for correct login details
bool loggedIn = false;
Console.WriteLine($"Welcome to the {restaurantName} menu app!");
do
{
    //username and password input with a check that something is inputted
    Console.Write("""
                  You will need to login with your username and password.
                  What is your username?
                  Username: 
                  """);
    username = Console.ReadLine();

    Console.Write("Password: ");
    password = Console.ReadLine();
    // Is the user registered?

    if (users.checkCredentials(username, password))
        loggedIn = true;
    else
    {
        if (username == "" || password == "")
        {
            Console.WriteLine("Please enter your login details next time.");
        }
        else 
            Console.WriteLine(
                "If you have an account with us. Something about those details aren't correct. " +
                "Please try again.\nPress enter to continue.");
        Console.WriteLine("Press enter to try again.");
        Console.ReadLine();
    }
    

    Console.Clear();
} while (loggedIn == false);



//While loop to repeat menu
sbyte menuItemChosen = -1;
string menuItemInput = "";
sbyte[] menuListItems = { 1,2,3,4,5 };

Menu menu = new Menu();

/*
 * TODO: change do while to a class which has a method to handle input e.g. .showMenu("Mains") or .showMenuMains();
 * 
    */

Console.WriteLine(menu.MenuLevel);
// sbyte called orderStage?
// do OrderBuilder.displayStage(orderStage); returns the next stage?
// if orderStage is -1 exit menu
// else OrderBuilder.DisplayStage(orderStage);
do
{
    //handle menu display

    switch (menu.MenuLevel)
    {
        case MenuLevelType.Mains:
            Console.Write($"""
                           Great to see you back {username}!
                           {menu.GetMainsMenu()}
                           Please select by entering a number for the menu item you would like to order.
                           Menu item desired:
                           """);
            break;
        case MenuLevelType.Sides:
            Console.Write($"""
                           What side would you like with that {username}?
                           {menu.GetSidesMenu()}
                           Please select by entering a number for the menu item you would like to order.
                           Menu item desired:
                           """);
            break;
        default:
            Console.WriteLine("Default");
            break;
        
    }
    menuItemInput = Console.ReadLine();

    //Convert input to a number 
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
        Console.WriteLine(
            "It doesn't seem like you chose an item from our menu. Press enter and we will give you another try.");
        Console.ReadLine();
        Console.Clear();
        menuItemChosen = -1;
    }
    else
    {
        switch (menu.MenuLevel)
        {
            case MenuLevelType.Mains:
                Console.WriteLine($"That's a great choice {username}. We'll serve a {menu.MainItemNameByIndex(menuItemChosen)} right up to you.");
                menu.MenuLevel = MenuLevelType.Sides;
                break;
            case MenuLevelType.Sides:
                Console.WriteLine($"That's a great choice {username}. We'll serve a number {menu.SideItemNameByIndex(menuItemChosen)} right up to you.");
                menu.MenuLevel = MenuLevelType.Exit;
                break;
            default:
                Console.WriteLine("Default");
                break;  
        }

        menuItemChosen = -1;
    }
        
} while (menu.MenuLevel != MenuLevelType.Exit);
// end of program
