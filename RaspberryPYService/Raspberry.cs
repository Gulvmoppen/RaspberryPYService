using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaspberryPYService
{
    public class Raspberry
    {
        public int Light { get; set; }
        public int Analog { get; set; }

        public int Tempreture { get; set; }

        public int Potentimeter { get; set; }

        public Raspberry()
        {
            
        }

        public Raspberry(int light, int analog, int tempreture, int potentimeter)
        {
            Light = light;
            Analog = analog;
            Tempreture = tempreture;
            Potentimeter = potentimeter;    
        }


    }
}