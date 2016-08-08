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
            string temp;
            if (this.temp == Temp)
            {
                return Temp;
            }
            else if (temp == Temp.IncreaseTemp )
            {
                return  Temperature.IncreaseTemp;
            }
            else if (temp == Temp.DecreaseTemp)
            {
                return Temperature.DecreaseTemp;
            }

            return "состояние: " + state + ", температура: " + Temp;
        }
    }
}