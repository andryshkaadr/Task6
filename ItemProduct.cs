namespace Task6
{
    public class ItemProduct : Item
    {
        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Price cannot be negative.");
                }
                _price = value;
            }
        }

        public ItemProduct(string title, double price) : base(title)
        {
            Price = price;
        }

        public override double GetPrice()
        {
            return _price;
        }
    }
}
