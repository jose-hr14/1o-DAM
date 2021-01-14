using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa para manejar listas
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(-1);
            list.Add(7);
            list.Add(8);
            list.Add(8);
            list.Add(0);
            list.Add(-5);

            for (int i = 0; i < list.Count; i++) //imprime toda la lista
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
