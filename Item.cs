namespace Task6
{
    public abstract class Item : IItem
    {
        private readonly string _title;

        public string Title
        {
            get { return _title; }
        }

        public Item(string title)
        {
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title), "Title cannot be null.");
            }
            _title = title;
        }

        public abstract double GetPrice();

        public virtual string GetInfo()
        {
            return $"Product: {Title}, Price: {GetPrice()}";
        }
    }
}
