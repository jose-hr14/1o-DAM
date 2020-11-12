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
            FillImage(bm, Color.White);
            FillCircle(bm, Color.Red, 250, 150, 50);
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    
                    if (y == 0 || x == 0 || x == (bm.Width - 1) || y == (bm.Height - 1)) //Aquí coloreamos el borde negro
                    {
                        bm.SetPixel(x, y, Color.Black);
                    }
                }
            }

            
        }

        //Vamos a poner un pixel rojo, usar esto para llenar el blaco de la bandera de japon
        //bitmap.SetPixel(10, 10, Color.Red);
        //Vamos a rellenar la img de rojo
        //for (int y = 0; y < bitmap.Height; y++)
        //{
        //    for (int x = 0; x < bitmap.Width; x++)
        //    {
        //        bitmap.SetPixel(x, y, Color.White);
        //    }
        //}
        public static void FillImage(Bitmap bm, Color Color)
        {
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    bm.SetPixel(x, y, Color);
                }
            }
        }

        public static void FillCircle(Bitmap bm, Color color, double centerx, double centery, double radius)
        {
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (GetDistance2d(centerx, centery, x, y) < radius)
                    {
                        bm.SetPixel(x, y, color);
                    }
                    
                }
            }

        }

        public static void PaintRomanFace(Bitmap bm)
        {
            FillImage(bm, Color.White);
            FillCircle(bm, Color.Black, bm.Width / 2, bm.Height / 2, 120); //Cabeza externa
            FillCircle(bm, Color.White, bm.Width / 2, bm.Height / 2, 110); //Cabeza borde interno
            FillCircle(bm, Color.Black, bm.Width / 2.5, bm.Height / 3, 20); //Ojo izquieda
            FillCircle(bm, Color.White, bm.Width / 2.5, bm.Height / 3, 10); //Pupila izquierda
            //Ojo izquierdo
            //Boca
            FillCircle(bm, Color.Black, bm.Width / 2, bm.Height / 2, 10); //Nariz
        }

        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(500, 300); //dimension completa de la imagen
            PaintRomanFace(bitmap);
            bitmap.Save("C:\\Users\\hernandez21107\\Desktop\\repos\\prueba.png");




            //Hacer bandera japon, radio de 50, color rojo, la posicion de su centro es (250, 150)
            //PaintJapaneseFlag(bitmap);
            //Poner la funcion de cara roman

        }
    }
}
