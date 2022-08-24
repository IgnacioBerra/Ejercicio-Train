//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            //for (int i = 0;i<100; i++)
            //{
           // var train = new Train("Train");
           // train.StartEngines();
           // Console.WriteLine("Hello World!");

           //for (int i = 0;i<10000000; i++)
           // {
           // var train = new Train("Train");
           // train.StartEngines();
           // Console.WriteLine("Hello World!");
           // }
            // Lo que sucede al intentar crear 10.000.000 de objetos, es que se empieza a 
            // saturar el espacio de memoria dedicado. Al ocuparse el espacio de memoria,
            // se empiezan a destruir objetos. Al ser eliminados, se empiezan a liberar recursos,
            //ejecutando así el print que habiamos hecho en el Library de que nos avisaba que se destruyó. 

            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");

            Console.WriteLine(t1==t2);
            Console.WriteLine(t2==t3);

            // Las expresiones t1==t2 y t2==3 arrojan False porque a pesar de tener el mismo identificador t1 y t2, 
            // el espacio de memoria que ocupan ambos objetos no es el mismo. Para que arrojará True, debería haberse asignado t2=t1, porque 
            // de esa manera t2 haría referencia al espacio de memoria de t1. Y en el caso de t2 y t3, sucede
            // que a pesar de ser objetos de la misma clase, estos no ocupan el mismo espacio de memoria, son objetos distintos. 
        }
    }
}