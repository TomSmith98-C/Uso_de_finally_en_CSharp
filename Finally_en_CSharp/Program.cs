using System;

namespace Finally_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Ingresa un numero.");
                int numero;
            try
            {
                numero = int.Parse(Console.ReadLine());

                }

            catch (Exception e)
            {
                Console.WriteLine("No es valido el numero  ");
            }

            //Finally se usa para poner todo lo que quieras que se ejecute aun si manda una excepcion el programa,
            //Siempre se ejecuta con o sin excepciones

            finally
            {
                numero = 0;
            }

            Console.WriteLine($"Salto a seccion finally donde el numero es igual a =  {numero}.");
        }
    }
}
