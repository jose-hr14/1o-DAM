using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica07
{
    class Program
    {
        static void Main(string[] args)
        {
            tListadeAlumnos listaAlumnos = new tListadeAlumnos();
            tListadeProfesores listaProfesores = new tListadeProfesores();
            tListadeCursos listaCursos = new tListadeCursos();

            //Gestion_Cursos.MenuPrincipal(listaCursos, listaAlumnos);
            //GestionAlumnos.MenuPrincipal(listaCursos, listaAlumnos);
            GestionProfesores.MenuPrincipal(listaProfesores);

            
        }
    }
}
