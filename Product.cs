namespace WinForms_HW_6
{
    public class Product
    {
        private string _description;
        private double _price;
        private string _characteristics;
        private string _productName;

        public double Price { get { return _price; } set => _price = value; }
        public string ProductName { get { return _productName; } }
        public string Description { get { return _description; } }

        public Product() { }

        public Product(string description, double price, string characteristics, string productName)
        {
            _description = description;
            _price = price;
            _characteristics = characteristics;
            _productName = productName;
        }
    }
}
