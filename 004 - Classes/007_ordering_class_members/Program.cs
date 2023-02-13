using System.Globalization;

/* --- Ordering Class Members --- */

class Product
{
    // 1) Private Attributes (Private Fields)
    private string _name;

    // 2) Auto Properties
    public double Price { get; private set; }
    public int Quantity { get; set; }

    // 3) Constructors
    public Product(string name, double price, int quantity)
    {
        _name = name;
        Price = price;
        Quantity = quantity;
    }

    // 4) Custom Properties
    public string Name
    {
        get { return _name; }
        set
        {
            if (value != null && value.Length > 1)
            {
                _name = value;
            }
        }
    }

    // 5) Methods
    public string TotalStockAvailable()
    {
        return (Price * Quantity).ToString("F2", CultureInfo.InvariantCulture);
    }

    public void AddProducts(int quantity)
    {
        Quantity += quantity;
    }
    public void RemoveProdutos(int quantity)
    {
        Quantity -= quantity;
    }

    public override string ToString()
    {
        return $"{_name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, {Quantity} " +
            $"units, Total: ${TotalStockAvailable()}";
    }
}