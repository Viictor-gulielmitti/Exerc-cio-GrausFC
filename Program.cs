using System;

namespace GRAUS
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada;
            double C, F;
            Console.WriteLine(".................[GRAUS].........................");
            Console.WriteLine ( " Digite a temperatura (em ° F): " );
            entrada  =  Console.ReadLine();
            C = Convert.ToDouble (entrada);
            F = (F: 32 / 1,8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ("$ \n Equivalência");
            Console.WriteLine ($" Essa temperatura em °C: { "C [GRAUS]"}");
            Console.WriteLine ("................[GRAUS].........................");
            
