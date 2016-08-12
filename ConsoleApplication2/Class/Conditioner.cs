using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Conditioner : Temperature
    {

        public Conditioner(string name, int min, int max, int temp)
            : base(name, min, max, temp)
        {
            this.temp = temp;
            this.min = min;
            this.max = max;
        }
        public int Temp
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

        public void DecreaseTemp()
        {
            if ( temp > 10)            { temp--; }
        
        }

        public void IncreaseTemp()
        {
            if (temp < 40)            { temp++; }

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
