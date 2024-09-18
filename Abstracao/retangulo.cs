using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class Retangulo : FormaGeometrica
    {
        private double _base;

        public double _Base
        {
            get { return _base; }
            set { _base = value; }
        }

        private double altura;
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public override double CalcularArea()
        {
            return (_base * altura);
        }


        public override double CalcularPerimetro()
        {
            return (2 * (_base + altura));
        }
        public override string ToString()
        {
            return "Retângulo";
        }

    }
}
