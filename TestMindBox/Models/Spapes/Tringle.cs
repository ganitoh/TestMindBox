using TestMindBox.Abstraction;

namespace TestMindBox.Models.Spapes
{
    public class Tringle : ISquare
    {
        public TringleSides Sides { get; set; }

        public Tringle(TringleSides sides)
        {
            Sides = sides;
        }

        public double CalculateSquare()
        {
            var halfPerimtr = (Sides.SideOne + Sides.SideTwo + Sides.SideThree) / 2;
            var differenceOne = halfPerimtr - Sides.SideOne;
            var differenceTwo = halfPerimtr - Sides.SideTwo;
            var differenceThree = halfPerimtr - Sides.SideThree;

            var square = Math.Sqrt(halfPerimtr * differenceOne * differenceTwo * differenceThree);

            return square;
        }

        public bool IsRightAngle()
        {
            double bigSide = Sides.GetBigSide();

            if (Sides.SideOne == bigSide)
                return IsRight(bigSide, Sides.SideTwo, Sides.SideThree);
            else if (Sides.SideTwo == bigSide)
                return IsRight(bigSide, Sides.SideOne, Sides.SideThree);
            else
                return IsRight(bigSide, Sides.SideOne, Sides.SideTwo);

        }

        private bool IsRight(double bigSide, double twoSide, double threeSide)
        {
            var squareBigSide = Math.Pow(bigSide, 2);
            var squareTwoSide = Math.Pow(twoSide, 2);
            var squareThreeSide = Math.Pow(threeSide, 2);

            if (squareBigSide == (squareTwoSide + squareThreeSide))
                return true;
            else
                return false;
        }
    }
}
