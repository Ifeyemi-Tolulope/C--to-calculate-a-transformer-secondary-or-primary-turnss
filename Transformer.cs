using System;

namespace App2 
{
     class Transformer
     {
        public Transformer(double primaryVolt, double secondaryVolt)
        {   
            PrimaryVolt    = primaryVolt;
            SecondaryVolt  = secondaryVolt;
         }
         
        const double Frequency = 50;
        const double FluxDensity = 1.1;
        const double AreaOfCore = 17.16;
        public double PrimaryVolt {get; set;}
        public double SecondaryVolt {get; set;}
        public double PrimaryTurn {get; set;}
        public double SecondaryTurn {get; set;}
        

        public void CalculatePrimaryTurn()
        {
           PrimaryTurn = PrimaryVolt / ( 4.44 * Frequency * FluxDensity * AreaOfCore );
        }
        public void CalculateSecondaryTurn()
        {
            SecondaryTurn = SecondaryVolt / ( 4.44 * Frequency * FluxDensity * AreaOfCore );
        }

     }
     
}
