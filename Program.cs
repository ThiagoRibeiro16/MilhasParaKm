using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
         string medida1;
         double milha;
         double km;

        Console.Clear();

         Console.Write("Informe a medida em milhas:");
         medida1 = Console.ReadLine();

         Console.WriteLine();

         milha = Convert.ToDouble(medida1);

         km = milha * 1.609;

         Console.WriteLine("equivalencia em quilometros:");

         Console.WriteLine();

         Console.WriteLine($"medida em milhas: {milha}");
         Console.WriteLine($"{km} km");


         
        }
    }
}
