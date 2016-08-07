using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Boiler : Temperature
    {

        public Boiler (int min, int max, int temp)
            : base(min, max, temp)
        {
            this.temp = temp;
            this.min = min;
            this.max = max;
        }

        public override string ToString()
        {
            string state;
            
            if (this.state)
            {
                state = "включен";
            }
            else
            {
                state = "выключен";
            }

   
            
            return "состояние: " + state + ", температура: " + Temp;
        }
    }
}