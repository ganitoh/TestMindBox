using TestMindBox.Abstraction;

namespace TestMindBox.Models.Spapes
{
    public class Circale : ISquare
    {
        private const double PI = Math.PI;
        public double Radius { get; set; }

        public Circale(double radius)
        {
            Radius = radius;
        }

        public double CalculateSquare()
            => PI * Math.Pow(Radius, 2);
    }
}
