using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class TrianguloReto : Triangulo
    {
        public double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public double altura;

        public double Altura
        {
            get { return lado; }
            set { lado = value; }
        }
        public override double CalcularArea()
        {
            return (lado * altura) / 2;
        }
        int h =0;

        

        public override double CalcularPerimetro()
        {

            double hipotenusa;
            hipotenusa = System.Math.Sqrt(Math.Pow(lado, 2) + Math.Pow(altura, 2));      
            return lado + hipotenusa + altura;

        }

    }
}
