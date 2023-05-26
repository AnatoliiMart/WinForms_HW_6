namespace WinForms_HW_6
{
    public class Product
    {
        private string? _description;
        private double  _price;
        private string? _characteristics;
        private string? _productName;

        public double  Price       { get => _price; }
        public string? ProductName { get => _productName; }
        public string? Description { get => _description; }

        public Product() { }

        public Product(string description, double price, string characteristics, string productName)
        {
            _description     = description;
            _price           = price;
            _characteristics = characteristics;
            _productName     = productName;
        }
    }
}
