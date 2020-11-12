using System.Drawing;
using System.Runtime.CompilerServices;

namespace Imagen
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(200, 100);


            //Vamos a poner un pixe rojo 
            //bitmap.SetPixel(10, 10, Color.Red);
            //Vamos a rellenar la img de rojo
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    bitmap.SetPixel(x, y, Color.White);
                }
            }



            bitmap.Save("C:\\Users\\hernandez21107\\Desktop\\repos\\prueba.png");
        }
    }
}
