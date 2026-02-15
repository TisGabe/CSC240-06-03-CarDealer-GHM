namespace CarDealer
{
    public sealed class CarModel
    {
        public string Name { get; }
        public string Trim { get; }
        public decimal MSRP { get; }
        public int MpgCity { get; }
        public int MpgHwy { get; }
        public string[] Highlights { get; }

        public CarModel(string name, string trim, decimal msrp, int mpgCity, int mpgHwy, string[] highlights)
        {
            Name = name;
            Trim = trim;
            MSRP = msrp;
            MpgCity = mpgCity;
            MpgHwy = mpgHwy;
            Highlights = highlights;
        }
    }
}
