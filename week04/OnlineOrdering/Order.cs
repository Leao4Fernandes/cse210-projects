public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetShippingCost()
    {
        if (_customer.IsCustomerUSA())
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0.0;
        foreach (Product product in _products)
        {
            totalPrice += product.TotalCost();
        }
        return totalPrice + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductID()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetName()}\n";
        shippingLabel += $"{_customer.GetAddress().GetFullAddress()}\n";
        return shippingLabel;
    }
}