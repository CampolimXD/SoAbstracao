using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class TrianguloEquilatero : Triangulo
    {
        private double _base;

        public double _Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public override double CalcularArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(_base, 2);
        }

        public override double CalcularPerimetro()
        {
            return 3 * _base;
        }
        public override string ToString()
        {
            return "Triângulo Equilátero";
        }
    }
}
