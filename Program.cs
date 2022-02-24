using System;

namespace Fundamentos
{
    class EntradaSalida
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.Read();
        }
    }
}
