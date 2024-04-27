namespace TestMindBox.Models.Shapes
{
    public struct TringleSides
    {
        public double SideOne { get; set; }
        public double SideTwo { get; set; }
        public double SideThree { get; set; }

        public TringleSides(double sideOne, double sideTwo, double sidethree)
        {
            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sidethree;
        }

        public double GetBigSide()
        {
            if (SideOne > SideTwo && SideOne > SideThree)
                return SideOne;
            else if (SideTwo > SideThree)
                return SideTwo;
            else
                return SideThree;

        }
    }
}
