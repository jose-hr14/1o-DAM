using System;
using System.Collections;
using System.Collections.Generic;
namespace ProgramacionSemanaSanta
{
    class Program
    {
        /*
        1 - Escribir un bucle que calcule la suma de cada tercer entero comenzando por i = 2, es decir, calcula la
        suma de 2+5+8+11…, para todos los valores de i menores que 100. Realizar este ejercicio utilizando:
        a) Sentencia while
        b) Sentencia do – while
        c) Sentencia for
        */
        public static void Ej01()
        {
            int x = 0;
            for (int i = 2; i < 100; i += 3)
            {
                Console.Write(" " + i + " +");
                x += i;
            }
        }
        /*
        2 - Escribir un programa que nos pida un carácter y lo busque en un array de caracteres previamente
        introducido para indicarnos cuantas veces aparece ese carácter en el array.
        */
        public static void Ej02_A()
        {
            int[] Array = new int[5] { 1, 2, 3, 4, 5 };
            int valor = 5;
            int contador = 0;
            while (contador < Array.Length)
            {
                if (Array[contador] == valor)
                {
                    Console.WriteLine("Existe");
                    break;
                }
                else if (contador == Array.Length - 1)
                    Console.WriteLine("No existe");
                contador++;
            }
        }
        public static void Ej02_B()
        {
            int[] Array = new int[5] { 1, 2, 3, 4, 5 };
            int valor = 5;
            int contador = 0;
            do
            {
                if (Array[contador] == valor)
                {
                    Console.WriteLine("Existe");
                    break;
                }
                else if (contador == Array.Length - 1)
                    Console.WriteLine("No existe");
                contador++;
            } while (contador < Array.Length);
        }
        public static void Ej02_C()
        {
            int[] Array = new int[5] { 1, 2, 3, 4, 5 };
            int valor = 33;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == valor)
                {
                    Console.WriteLine("Existe");
                    break;
                }                    
                else if (i == Array.Length - 1)
                    Console.WriteLine("No existe");
            }
        }
        /*
         3 - Escribir un programa que nos pida un determinado número mayor que 0. Una vez introducido, el
        programa nos devolverá la suma de todos los múltiplos de 7, es decir si introducimos el valor 22, el
        programa nos devolverá la suma 7+14+21
         */
        public static void Ej03()
        {
            Console.Write("Introduce un valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            int multiplo = 7;
            int resultado = 0;
            for (int multiplos = multiplo; multiplos < valor; multiplos += multiplo)
            {
                resultado += multiplos;
            }
        }
        /*
         4 - Escribir un programa que recorra un array de caracteres y nos indique cuántos de estos caracteres
        corresponden a números y cuantos a letras.
         */
        public static void Ej04()
        {
            char[] Array = new char[10] { '1', 'a', 'r', '4', '3', 'h', 'r', '9', 'z', 'l'};
            int contador_caracteres = 0;
            int contador_numeros = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (int.TryParse(Convert.ToString(Array[i]), out int valor))
                    contador_numeros++;
                else
                    contador_caracteres++;
            }
            Console.WriteLine("El array contiene " + contador_numeros + " numeros y " + contador_caracteres + " carácteres");
        }
        /*
        5 - Escribir un programa que recorra un string donde guardaremos una determinada palabra y nos diga
        cuantas vocales y cuantas consonantes tiene
         */
        public static void Ej05()
        {
            List<char> Vocales = new List<char> { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú' };
            Console.Write("Introduce un mensaje: ");
            string mensaje = Console.ReadLine();            
            int num_vocales = 0;
            int num_consonantes = 0;
            for (int i = 0; i < mensaje.Length; i++)
            {
                if (mensaje[i] == ' ')
                    continue;

                if (Vocales.Contains(mensaje[i]))
                    num_vocales++;
                else
                    num_consonantes++;                
            }
        }
        /*
         6 - Escribir un programa que lea los caracteres de un array y los guarde en otro en sentido opuesto.
         */
        public static void Ej06()
        {
            char[] Array01 = new char[10] { '1', 'a', 'r', '4', '3', 'h', 'r', '9', 'z', 'l' };
            char[] Array02 = new char[Array01.Length];
            int j = 0;
            for (int i = Array01.Length - 1; i >= 0; i--)
            {
                Array02[j] = Array01[i];
                j++;
            }
        }
        /*
         7 - Recorrer un array de caracteres (solo tendrá letras, mayúsculas o minúsculas) y las cambiará de
        formato. Las mayúsculas pasarán a minúsculas y las minúsculas a mayúsculas.
         */
        public static void Ej07()
        {
            char[] Array = new char[10] { 'A', 'b', 'C', 'd', 'E', 'f', 'G', 'h', 'I', 'j' };
            for (int i = 0; i < Array.Length; i++)
            {
                if (char.IsLower(Array[i]))
                    Array[i] = char.ToUpper(Array[i]);
                else
                    Array[i] = char.ToLower(Array[i]);
                    
            }
            
        }
        /* 8 - Programa que calcule el producto de un array de decimales. */
        public static void Ej08()
        {
            float[] Array = new float[5] { 1.5F, 2.5F, 3.5F, 4.5F, 5.5F };
            float resultado = 1;
            for (int i = 0; i < Array.Length; i++)
            {
                resultado *= Array[i];
            }
        }
        /* 9 - Realizar un programa que calcule los 100 primeros números primos. */
        public static void Ej09()
        {
            List<int> Numeros_Primos = new List<int>();
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && j != i)
                        break;
                    else if (i % j == 0 && j == i)
                        Numeros_Primos.Add(j);
                }
            }
        }
        /*
         10 - Escribir un programa que lea un valor entero positivo y determine si el número es un número primo
        o si es un número de Fibonacci (un número de Fibonacci es aquel que es igual a la suma de todos los
        números anteriores a él, por ejemplo 3=2+1, es un número de Fibonacci y además es primo). Consejo:
        Realizar este programa en dos partes, primero para determinar si un número es primo y luego para
        determinar si es un número Fibonacci, una vez comprobéis que funciona por separado combinarlos para
        obtener el resultado deseado
        */
        public static bool EsPrimo(int valor)
        {
            for (int i = 2; i <= valor; i++)
            {
                if (valor % i == 0 && i != valor)
                    break;
                else if (valor % i == 0 && i == valor)
                    return true;
            }
            return false;
        }
        public static List<int> GenerateFibonacciList(int value_limit)
        {
            int a = 0;
            int b = 1;
            int aux = 0;
            List<int> Fibonacci = new List<int>();
            Fibonacci.Add(a);          
            do
            {
                Fibonacci.Add(b);
                aux = b;
                b = a + b;
                a = aux;                
            } while (b <= value_limit);
            return Fibonacci;
        }
        public static bool EsFibonacci(int valor)
        {
            List<int> ListaFibonacci = GenerateFibonacciList(valor);
            if (ListaFibonacci.Contains(valor))
                return true;
            else
                return false;
        }
        public static void Ej10(int valor)
        {
            if (EsPrimo(valor))
                Console.WriteLine("El valor " + valor + " es primo.");
            if (EsFibonacci(valor))
                Console.WriteLine("El valor " + valor + " está en la serie de Fibonacci");
        }
        /* 11 - Calcular la suma de los números impares anteriores a n, donde n es un valor que se le pide al
        usuario por consola. */
        public static void Ej11(int valor)
        {
            int resultado = 0;
            for (int i = valor - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                    resultado += i;
            }

        }
        /*12 - Realizar un programa que nos calcule los datos de un préstamo.Nos pedirá la cantidad prestada,
        los intereses(será un número entero que representará el % sobre la cantidad prestada) y los años para
        devolverlo.El programa nos dirá:
        1- La cantidad de intereses que se paga al mes.
        2- La cantidad a pagar por el cliente cada mes.
        3- La cantidad de deuda no pagada al final de cada mes.
        4- El número de cuotas restantes.
        5- Cantidad total de interés pagado al final del préstamo.
        6- Cantidad total que habrá pagado el cliente al finalizar el préstamo */
        public static void Ej12(double cantidad_prestada, int porcentaje_intereses, int años)
        {
            int meses = años * 12;
            double intereses = (cantidad_prestada * porcentaje_intereses) / 100;
            double cantidad_mas_intereses = cantidad_prestada + intereses;
            //1 - La cantidad de intereses que se paga al mes.
            double intereses_mensuales = intereses / meses;
            //2- La cantidad a pagar por el cliente cada mes.
            double pago_mensual = cantidad_mas_intereses / meses;
            //3- La cantidad de deuda no pagada al final de cada mes.
            int num_mes = 3;
            double cantidad_restante = cantidad_mas_intereses - (pago_mensual * num_mes);
            //4- El número de cuotas restantes.
            double cuotas_restantes = meses - num_mes;
            //5- Cantidad total de interés pagado al final del préstamo.
            //intereses;
            //6- Cantidad total que habrá pagado el cliente al finalizar el préstamo */
            //cantidad_mas_intereses;
        }
        //13 - Realizar un programa que acepte el nombre de un estudiante y las notas de cada uno de los tres
        //trimestres y nos calcule la nota media.El programa pedirá nombres de estudiante y sus notas hasta que
        //no metamos en estudiante la palabra FIN.
        public static void Ej13()
        {
            string nombre_estudiante;
            double nota01;
            double nota02;
            double nota03;
            double media;
            do
            {
                Console.Write("Introduce un nombre para el estudiante: ");
                nombre_estudiante = Console.ReadLine();
                Console.Write("Introduce una nota para el primer trimestre: ");
                nota01 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce una nota para el segundo trimestre: ");
                nota02 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce una nota para el tercer trimestre: ");
                nota03 = Convert.ToInt32(Console.ReadLine());
                media = (nota01 + nota02 + nota03) / 3;
                Console.WriteLine(media);
            } while (nombre_estudiante != "FIN");
        }
        //14 - Modificar el programa anterior para que calcule la media, pero dando diferentes pesos a cada uno
        //de los trimestres.El primer trimestre será un 30% de la nota final, el segundo un 30% y el tercero un
        //40%.
        public static void Ej14()
        {
            string nombre_estudiante;
            double nota01;
            double nota02;
            double nota03;
            double media;
            do
            {
                Console.Write("Introduce un nombre para el estudiante: ");
                nombre_estudiante = Console.ReadLine();
                Console.Write("Introduce una nota para el primer trimestre: ");
                nota01 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce una nota para el segundo trimestre: ");
                nota02 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce una nota para el tercer trimestre: ");
                nota03 = Convert.ToInt32(Console.ReadLine());
                media = nota01 * 0.30 + nota02 * 0.30 + nota03 * 0.40;
                Console.WriteLine(media);
            } while (nombre_estudiante != "FIN");
        }
        //15 - Escribir un programa que pase cualquier número entero en su correspondiente notación romana.
        //Por ejemplo 15 – XV(Consejo: empezar por números pequeños, por ejemplo, del 1 al 9, luego con
        //números de 10 en 10, por ejemplo, del 10 al 100…).
        public static void Ej15()
        {
            string[] unidades = new string[9] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] decenas = new string[9] { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
            string[] centenas = new string[9] {"C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string numero = "444";
            string indice = "0";
            int cifras = 0;
            Console.Write("El número " + numero + " en notación romana es: ");
            for (int i = 0; i < numero.Length; i++)
            {                
                cifras = numero.Length - i;
                indice = Convert.ToString(numero[i]);
                switch (cifras)
                {
                    case 1:
                        Console.Write(unidades[Convert.ToInt32(indice) - 1]);
                        break;
                    case 2:
                        Console.Write(decenas[Convert.ToInt32(indice) - 1]);
                        break;
                    case 3:
                        Console.Write(centenas [Convert.ToInt32(indice) - 1]);
                        break;
                    default:
                        Console.Write("El número de cifras se sale del rango");
                        break;
                }
            }
        }
        //16 - Realizar un programa que pida una cantidad de dinero y muestre en una etiqueta cuantos billetes
        //de 500 euros, de 200, de 100, de 50, de 20, de 10 de 5 y monedas de 2 y 1 euro le corresponden.Por
        //ejemplo: a 672 euros le corresponde 1 de 500, 1 de 100 1 de 50, 1 de 20 y dos monedas de 2 euros.
        public static void Ej16()
        {
            List<int> Billetes = new List<int> { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int cantidad = 672;
            int num_billetes;
            for (int i = 0; i < Billetes.Count; i++)
            {
                Ej16Aux(ref cantidad, Billetes[i], out num_billetes);
                if (num_billetes > 0 && i < 7)
                    Console.WriteLine(num_billetes + " billete/es de " + Billetes[i]);
                else if (num_billetes > 0 && i > 6)
                    Console.WriteLine(num_billetes + " moneda/as de " + Billetes[i]);
            }
            
        }

        public static void Ej16Aux(ref int cantidad, int billete, out int num_billetes)
        {
            num_billetes = 0;
            while ((cantidad - billete) >= 0)
            {
                cantidad = cantidad - billete;
                num_billetes++;
            }                
        }
        //17 - Realizar el programa anterior pero también con céntimos.
        public static void Ej17()
        {
            List<double> Billetes = new List<double> { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
            double cantidad = 672.90;
            int num_billetes;
            for (int i = 0; i < Billetes.Count; i++)
            {
                Ej17Aux(ref cantidad, Billetes[i], out num_billetes);
                if (num_billetes > 0 && i < 7)
                    Console.WriteLine(num_billetes + " billete/es de " + Billetes[i] + " euros");
                else if (num_billetes > 0 && i > 6 && i < 9)
                    Console.WriteLine(num_billetes + " moneda/as de " + Billetes[i] + " euros");
                else if (num_billetes > 0 && i > 8)
                    Console.WriteLine(num_billetes + " moneda/as de " + Billetes[i] * 100 + " centimos");
            }
        }
        public static void Ej17Aux(ref double cantidad, double billete, out int num_billetes)
        {
            num_billetes = 0;
            while ((cantidad - billete) >= 0)
            {
                cantidad = cantidad - billete;
                num_billetes++;
            }
        }
        //18 - Escribir un programa que acepte números enteros positivos.El programa irá aceptando números
        //hasta que se introduzca un número negativo.Sacará por pantalla cuál es el número mayor y el menor
        //de todos los números introducidos (sin contar el negativo).
        public static void Ej18()
        {
            int valor = 0;
            List<int> Lista = new List<int>();
            while (valor >= 0)
            {
                Console.WriteLine("Introduce un número: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor >= 0)
                Lista.Add(valor);
            }
            Lista.Sort();
            Console.WriteLine("El mayor número de todos los introducidos es el: " + Lista[Lista.Count - 1]);
            Console.WriteLine("El menor número de todos los introducidos es el: " + Lista[0]);
        }
        //19 - Realizar un programa que muestre por pantalla los números del 1 al número introducido por el
        //usuario.Hacerlo con for, con while y otro con do..while.
        public static void Ej19()
        {
            Console.WriteLine("Introduce un númeor: ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= value; i++)
            {                
                if (i == value)
                    Console.Write(i);
                else
                    Console.Write(i + ", ");
            }
        }
        public static void Ej19B()
        {
            int contador = 0;
            Console.WriteLine("Introduce un númeor: ");
            int value = Convert.ToInt32(Console.ReadLine());
            while (contador < value)
            {
                contador++;
                if (contador == value)
                    Console.Write(contador);
                else
                    Console.Write(contador + ", ");
                
            }
        }
        //20 - Realizar un programa que muestre por pantalla los números pares desde el 0 hasta el número
        //introducido por el usuario.Hacerlo con for, con while y otro con do..while.
        public static void Ej20()
        {
            Console.WriteLine("Introduce un númeor: ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= value; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + ", ");
            }
        }
        //21 - Realizar un programa similar al anterior, en el que se vayan introduciendo números y se sumen
        //siempre y cuando estos números estén entre 0 y 9, en otro caso terminará la introducción de números
        //mostrando cuál es la suma.
        public static void Ej21()
        {
            int valor = 0;
            int resultado = 0;
            while (valor >= 0 && valor <= 9)
            {
                Console.WriteLine("Introduce un número: ");
                valor = Convert.ToInt32(Console.ReadLine());
                resultado += valor;
            }
        }
        static void Main(string[] args)
        {
            Ej20();

            






        }
    }
}
