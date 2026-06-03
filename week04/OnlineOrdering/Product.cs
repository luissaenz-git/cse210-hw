public class Product
{
    private string _name = "";
    private string _productId = "";
    private double _price = 0.0;
    private int _quantity = 0;

    public double _totalCostProduct()
    {
        return _price * _quantity;
    }

    public string productPackingLabel()
    {
        return _name + " ID:" + _productId;
    }

    public void SetProductInfo(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }



}