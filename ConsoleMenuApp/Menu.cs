using System.Text;
using ConsoleMenuApp.Enumerations;

namespace ConsoleMenuApp;

public class Menu
{
    private List<Main> _mainItems = new List<Main>();
    private List<Side> _sideItems = new List<Side>();
    private MenuLevelType _menuLevel;


    public Menu()
    {
        this._menuLevel = MenuLevelType.Mains;
        this.SetMainMenu();
        this.SetSideMenu();
    }
    
    //sets the menu items up
    private void SetMainMenu()
    {
        //create menu items
        Main main1 = new Main("Four Flame-grilled Boneless Chicken Thighs");
        Main main2 = new Main("One Chicken Butterfly");
        Main main3 = new Main("Grilled Chicken Wrap");
        Main main4 = new Main("1/2 Peri Peri Chicken");
        Main main5 = new Main("Vegan Salad");
        //add to the menu
        this._mainItems.Add(main1);
        this._mainItems.Add(main2);
        this._mainItems.Add(main3);
        this._mainItems.Add(main4);
        this._mainItems.Add(main5);

    }
    private void SetSideMenu()
    {
        Side side1 = new Side("PERi-Mac & Cheese", 4.75m);
        Side side2 = new Side("Spicy Rice", 3.75m);
        Side side3 = new Side("Creamy Mash", 3.75m);
        Side side4 = new Side("Chips", 3.75m);
        Side side5 = new Side("Leafy Green Salad", 4.25m);
        Side side6 = new Side("Garlic Bread", 3.75m);
        // add to menu
        this._sideItems.Add(side1);
        this._sideItems.Add(side2);
        this._sideItems.Add(side3);
        this._sideItems.Add(side4);
        this._sideItems.Add(side5);
        this._sideItems.Add(side6);
    }

    public string GetMainsMenu()
    {
        if (this._mainItems.Count == 0)
            return "No Items on menu.";
        else
        {
            StringBuilder builder = new StringBuilder("Please select a menu item from today's specials.\n");
            byte count = 1;
            foreach (Main item in this._mainItems)
            {
                builder.Append($"{count}. {item.Name}\n");
                count++;
            }

            builder.Append("""

                           """);

            return builder.ToString();
        }
    }

    public string GetSidesMenu()
    {
        if (this._sideItems.Count == 0)
            return "No Items on menu.";
        else
        {
            StringBuilder builder = new StringBuilder("Please select a side.\n");
            byte count = 1;
            foreach (Side item in this._sideItems)
            {
                builder.Append($"{count}. {item.Name}\n");
                count++;
            }

            builder.Append("""

                           """);

            return builder.ToString();
        }
    }
    public MenuLevelType MenuLevel
    {
        get { return this._menuLevel; }
        set { this._menuLevel = value; }
    }

    public string MainItemNameByIndex(sbyte itemNumber)
    {
        return  itemNumber-1 < _mainItems.Count ? _mainItems[itemNumber-1].Name : "no item here";
    }
    
    public string SideItemNameByIndex(sbyte itemNumber)
    {
        return  itemNumber-1 < _sideItems.Count ? _sideItems[itemNumber-1].Name : "no item here";
    }
}