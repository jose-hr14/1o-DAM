using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public abstract class Figura
    {
        private int mPosicionX, mPosicionY;
        protected string mColor;

        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        public abstract string quienSoy();

        public abstract double Area();


        public Figura (int x, int y, string color)
        {
            mPosicionX = x;
            mPosicionY = y;
            mColor = color;
        }
    }
}
