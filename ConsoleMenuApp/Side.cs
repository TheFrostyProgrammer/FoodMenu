using ConsoleMenuApp.Enumerations;

namespace ConsoleMenuApp;

internal class Side : Food
{
    private SizeType _size;
    public Side(string name, decimal cost) : base(name, cost)
    {
    }

    public SizeType Size
    {
        get { return this._size; }
        set { this._size = value; }
    }
}