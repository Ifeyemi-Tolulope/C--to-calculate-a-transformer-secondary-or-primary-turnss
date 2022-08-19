using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            double primaryVolt      = 200;  
            double secondaryVolt    = 6;   

            Transformer transformer = new Transformer(primaryVolt, secondaryVolt);

            transformer.CalculatePrimaryTurn();
            transformer.CalculateSecondaryTurn();

            Console.WriteLine("Programming Assignment Group 2 \n");
            Console.WriteLine("The number of primary turns of coils is {0}",transformer.PrimaryTurn);
            Console.WriteLine("The number of Secondary turns of coils is {0}",transformer.SecondaryTurn);
        }
    }
}

