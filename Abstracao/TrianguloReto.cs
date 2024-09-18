using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class TrianguloReto : Triangulo
    {
        private double _base;

        public double _Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double altura;

        public double Altura
        {
            get { return _base; }
            set { _base = value; }
        }
        public override double CalcularArea()
        {
            return ((_base * altura) / 2);
        }
            

        public override double CalcularPerimetro()
        {

            double hipotenusa;
            hipotenusa = System.Math.Sqrt(Math.Pow(_base, 2) + Math.Pow(altura, 2));      
            return _base + hipotenusa + altura;

        }

    }
}
