
public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string name, string title, decimal price)
        : base(name, title, price)
    {
        this.Price = price;
    }

    protected override decimal Price
    {
        set { base.Price = value + (30 * value / 100); }
    }
}


