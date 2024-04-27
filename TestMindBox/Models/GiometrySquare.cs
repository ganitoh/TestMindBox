using TestMindBox.Abstraction;

namespace TestMindBox.Models
{
    public class GiometrySquare
    {
        private readonly ISquare _square;

        public GiometrySquare(ISquare square)
        {
            this._square = square;
        }

        public double GetSquare() 
            => square.CalculateSquare();
    }
}
