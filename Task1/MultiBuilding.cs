namespace Task1
{
    internal sealed class MultiBuilding : Building
    {
        int floors;
        int Floors
        {
            get
            { 
                return floors; 
            }
            set
            {
                if (floors<1)
                {
                    floors = 1;
                }
                else
                {
                    floors = value;
                }
            }
        }
        public MultiBuilding(string adress, double l, double b, double h, int floors)
            : base(adress, l, b, h)
        {
            this.floors = floors;
        }
    public new string Print()
    {
        string result = base.Print();
        result += $"\nЭтажность: {floors}";
        return result;
    }
}
}
