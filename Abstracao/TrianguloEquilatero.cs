using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class TrianguloEquilatero : Triangulo
    {
        public double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 3 * lado;
        }
    }
}
