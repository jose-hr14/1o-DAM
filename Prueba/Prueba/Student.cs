using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    class Student
    {
        public string id;
        public string name;

        public string getNameTwice() //Esta funcion diferencia al resto en que no es static y puede actuar con un objeto inconcreto. Es un método de objeto
        {
            return this.name + this.name;
        }
    }
}
