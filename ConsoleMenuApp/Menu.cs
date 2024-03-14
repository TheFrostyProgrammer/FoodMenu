using System.Text;

namespace ConsoleMenuApp;

public class Menu
{
    private List<Main> _items = new List<Main>();


    public Menu()
    {
        this.setMenu();
    }
    
    //sets the menu items up
    private void setMenu()
    {
        //create menu items
        Main main1 = new Main("Four Flame-grilled Boneless Chicken Thighs");
        Main main2 = new Main("One Chicken Butterfly");
        Main main3 = new Main("Grilled Chicken Wrap");
        Main main4 = new Main("1/2 Peri Peri Chicken");
        Main main5 = new Main("Vegan Salad");
        //add to the menu
        this._items.Add(main1);
        this._items.Add(main2);
        this._items.Add(main3);
        this._items.Add(main4);
        this._items.Add(main5);

    }

    public string getMenu()
    {
        if (this._items.Count == 0)
            return "No Items on menu.";
        else
        {
            StringBuilder builder = new StringBuilder("Please select a menu item from today's specials\n");
            byte count = 1;
            foreach (Main item in this._items)
            {
                builder.Append($"{count}. {item.Name}\n");
                count++;
            }

            builder.Append("""

                           """);

            return builder.ToString();
        }
    }
}