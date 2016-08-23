using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Conditioner : Temperature
    {
        private int max;
        private int min;
        private int temp;
        internal Conditioner(int max, int min, int temp)
            : base(max, min, temp)
        {
            this.temp = temp;
            this.max = max;
            this.min = min;
        }

        public  int Temp
        {
            get
            {  
                return temp;     
            }
            set
            {
                if (value < max && value > min)
                {
                    temp = value;
                }
            }
        }
        public int DecreaseTemp()
        {
            return Temp--;
        }

        public int IncreaseTemp()
        {
            return Temp++;
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