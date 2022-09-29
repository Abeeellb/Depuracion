using System;

namespace Depuracion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a hacer una operaciones de chill");
            int x;
            int y;
            int z;
            x = 9;
            y = 11;
            z = 25;
            z= x + y + z;
            z= x * 65 - z;
            Console.WriteLine("El resultado de las operaciones es " + z);
        }
    }
}