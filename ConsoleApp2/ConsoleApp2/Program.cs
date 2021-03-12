namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a;
            double b;
            double c;
            double x1;
            double x2;
            double aux;

            a = 30.0;
            b = 100.0;
            c = 40.0;
            aux = (b * b) - 4 * a * c;

            System.Console.WriteLine("0" + "=" + "ax^2" + "*" + "bx" + "*" + "c");
            System.Console.WriteLine("a" + "=" + a);
            System.Console.WriteLine("b" + "=" + b);
            System.Console.WriteLine("c" + "=" + c);
            System.Console.WriteLine("x" + "=" + "?");
                        
            x2 = (-b + System.Math.Sqrt(aux)) / (2 * a);
            x1 = (-b - System.Math.Sqrt(aux)) / (2 * a);

            System.Console.WriteLine("x1" + "=" + x1);
            System.Console.WriteLine("x2" + "=" + x2);



        }
    }
}
