using System;

namespace Abstracao
{
    public class Quadrado : FormaGeometrica
    {
       

        private int _base;

        public int Base
        {
            get { return _base; }
            set { _base = value; }
        }


        public override double CalcularArea()
        {
            return _base * _base;
        }
        

        public override double CalcularPerimetro()
        {
            return (_base * 4);
        }
    }
}
