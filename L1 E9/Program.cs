using System;

namespace SwappingValues
{
    /*  E9. Scrieti un program care interschimba 
            valoarea a doua variabile intregi
    */
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            int y;

            Console.WriteLine("Introduceti doua numere \n");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            int z;
            z = x;
            x = y;
            y = z;
           
            Console.WriteLine("Numerele dupa interschimbare sunt:");
            Console.WriteLine($"{x}, {y}");
        }
    }
}
