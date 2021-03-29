using System;

namespace CorrecionExamenEv02
{
    class Program
    {
        public static void Ej01()
        {
            int[] Array01 = new int[] { 3, 6, 7, 9, 5 };
            int[] Array02 = new int[] { 5, 6, 8, 7, 5 };
            bool esta = false;
            for (int i = 0; i < Array01.Length; i++)
            {
                for (int j = 0; j < Array02.Length; j++)
                {
                    if (Array01[i] == Array02[j])
                    {
                        esta = true;
                    }
                    else
                    {
                        esta = false;
                    }

                }
                if (!esta)
                {
                    Console.WriteLine("El numero no esta");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
