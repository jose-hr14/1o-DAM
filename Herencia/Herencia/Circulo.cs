using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Circulo : Figura
    {
        private int mRadio;

        public override string quienSoy()
        {
            return "soy un circulo";
        }

        public override double Area()
        {
            return 3.14 * mRadio * mRadio;
        }

        public Circulo(int x, int y, string color, int radio) : base (x, y, color)
        {
            mRadio = radio;
        }
    }
}
