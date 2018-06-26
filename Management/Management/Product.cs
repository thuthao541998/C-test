namespace Management
{
    public class Product
    {
        private string _productID;
        private string _productName;
        private decimal _price;

        public string ProductId
        {
            get => _productID;
            set => _productID = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public Product(string productId, string productName, decimal price)
        {
            _productID = productId;
            _productName = productName;
            _price = price;
        }
    }
}