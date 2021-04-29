using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Objetos
{
    class Fecha
    {
        int dia;
        int mes;
        int año;
        
        

        public object OrderDate { get; private set; }

        public void SetDia(int dia)
        {
            this.dia = dia;
        }
        public void SetMes(int mes)
        {
            this.mes = mes;
        }
        public void SetAño(int año)
        {
            this.año = año;
        }

        public int GetDia()
        {
            return this.dia;
        }
        public int GetMes()
        {
            return this.mes;
        }
        public int GetAño()
        {
            return this.año;
        }

        public void PrintFecha()
        {
            Console.WriteLine(GetDia());
            Console.WriteLine(GetMes());
            Console.WriteLine(GetAño());
        }



    }
}
