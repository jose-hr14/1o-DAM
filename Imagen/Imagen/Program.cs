using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Imagen
{
    class Program
    {

        public static double GetDistance2d(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return System.Math.Sqrt(vx * vx + vy * vy);
        }
        
        public static void PaintJapaneseFlag(Bitmap bm) //Cambiar el bnombre de bitmap por bm
        {
            //Hacer bandera japon, radio de 50, color rojo, la posicion de su centro es (250, 150)
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (GetDistance2d(250, 150, x, y) < 50)
                    {
                        bm.SetPixel(x, y, Color.Red);
                    }
                    if (y == 0 || x == 0 || x == (bm.Width - 1) || y == (bm.Height - 1)) //Aquí coloreamos el borde negro
                    {
                        bm.SetPixel(x, y, Color.Black);
                    }
                }
            }

            
        }

        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(500, 300); //dimension completa de la imagen


            //Vamos a poner un pixel rojo 
            //bitmap.SetPixel(10, 10, Color.Red);
            //Vamos a rellenar la img de rojo
            //for (int y = 0; y < bitmap.Height; y++)
            //{
            //    for (int x = 0; x < bitmap.Width; x++)
            //    {
            //        bitmap.SetPixel(x, y, Color.White);
            //    }
            //}


            //Hacer bandera japon, radio de 50, color rojo, la posicion de su centro es (250, 150)
            PaintJapaneseFlag(bitmap);
            bitmap.Save("C:\\Users\\hernandez21107\\Desktop\\repos\\prueba.png");
        }
    }
}
