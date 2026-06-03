public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer = new Customer();

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double totalCostOrder()
    {
        double totalCost = 0.0;
        foreach (Product product in _products)
        {
            totalCost += product._totalCostProduct();
        }
        if (_customer.isInUSA())
        {
            totalCost += 5.0;
        }
        else
        {
            totalCost += 35.0;
        }
        return totalCost;
    }

    public string packingLabel()
    {
        string packingLabels = "";
        foreach (Product product in _products)
        {
            packingLabels = packingLabels + "\n" + product.productPackingLabel();
        }
        return packingLabels;
    }

    public string shippingLabel()

    {
        return _customer.GetCustomerAddress();
    }

    public void SetCustomerOrder(string customerOrder)
    {
        string[] strings = customerOrder.Split(';');
        foreach (string str in strings)
        {
            string[] productInfo = str.Split(',');
            Product product = new Product();
            product.SetProductInfo(productInfo[0], productInfo[1], double.Parse(productInfo[2]), int.Parse(productInfo[3]));
            AddProduct(product);
        }
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
}