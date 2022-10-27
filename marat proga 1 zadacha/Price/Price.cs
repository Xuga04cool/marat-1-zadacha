namespace Price
{
    public struct Price
    {
        public string Name;
        public string Shop;
        public int Cost;

        public Price(string name, string shop, int cost)
        {
            Name = name;
            Shop = shop;
            Cost = cost;
        }

        public string ToString()
        {
            return $"{Name} {Shop} {Cost}";
        }
    }
}