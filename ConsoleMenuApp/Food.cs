namespace ConsoleMenuApp;

internal class Food
{
    private string? _name;
    private decimal? _cost;

    public Food(string name, decimal cost)
    {
        this._name = name;
        this._cost = cost;
    }

    public string Name
    {
         get { return this._name; }
    }
}