namespace FuncionTutorial
{
    class Maths
    {
        // Funcion 1
        public static SolucionEcuacion CalcularResultado(double a, double b, double c)
        {

            double aux;
            double solucion1;
            double solucion2;
            SolucionEcuacion solucion;
            solucion = new SolucionEcuacion;
            aux = (b * b) - (4 * a * c);
            solucion1 = (-b + System.Math.Sqrt(aux)) / (2 * a);
            solucion2 = (-b - System.Math.Sqrt(aux)) / (2 * a);

            return solucion;
        }

    }
}
