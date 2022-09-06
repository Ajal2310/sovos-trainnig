using System;

namespace test
{
    /*
        AJAL 20220906

        Ejercicio toma una cadena de entrada e invierte el orden de lso caracteres eliminando los caracteres "(" y ")"
    */
    public class test
    {
        public static void Main ()
        {
            Console.WriteLine("==========Reversa string==========");

            //Solicita datos de entrada
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingrese una cadena para invertir: ");
            Console.ResetColor();


            //Lee cadena de entrada desde consola
            string entrada = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==>Entrada: " + entrada);
            Console.ResetColor();


            //Elimina caracteres no deseados
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Eliminando caracteres: '(' y ')' ");
            Console.ResetColor();

            entrada = entrada.Replace("(", "").Replace(")", "");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(entrada);
            Console.ResetColor();


            //Invierte el sentido de la cadena
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Invirtiendo cadena");
            Console.ResetColor();

            char[] charArray = entrada.ToCharArray();
            Array.Reverse(charArray);
            entrada = new string(charArray);


            //Muestra resultado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Resultado");
            Console.WriteLine("=====> " + entrada);
            Console.ResetColor();
        }
    }
}