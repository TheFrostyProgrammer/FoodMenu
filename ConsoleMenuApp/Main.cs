namespace ConsoleMenuApp;

internal class Main : Food
{
    private string? _Side;
    private string? _Drink;

    public Main(string name, decimal cost, string side, string drink) : base(name, cost)
    {
        this._Side = side;
        this._Drink = drink;
    }

    public Main(string name, string side = "Spicy Rice", string drink = "Coke Zero") : base(name, 9.99m)
    {
        this._Side = side;
        this._Drink = drink;
    }

    public string? Side
    {
        get { return _Side; }
        set { this._Side = value; }
    }

    public string? Drink
    {
        get { return _Drink; }
        set { this._Side = value; }
    }
    
    
}