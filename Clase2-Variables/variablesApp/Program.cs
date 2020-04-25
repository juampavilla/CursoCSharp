using System;

namespace variablesApp
{
    class Program
    {
        /** Mostremos por pantalla el mensaje: "¿Cuánto es 25 x 75 ?" **/
        // Guardemos en una variable el valor 25
        // Guardemos en otra variable el valor 75
        // Realicemos una operación de multiplicación entre esas variables
        // Y mostremos por pantalla: 
                //"El resultado es:" + el valor de una variable con el resultado.
        
        // Aclaración: la operación de multiplicación en C# se define utilizando el *
        static void Main(string[] args)
        {
            //inicialización de variables
            int primerTermino = 25;
            int segundoTermino = 75;

            //multiplicación de las variables
            int resultadoMult = primerTermino * segundoTermino;
            
            //salida en pantalla del resultado:
            Console.WriteLine("El resultado es:" + resultadoMult);
        }
    }
}
