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

        public void DecreaseTemp()
        {
            for (; temp > min; temp--)
            { }

        }

        public void IncreaseTemp()
        {
            for (; temp < max; temp++) { }
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


            return "состояние: " + state + ", температура: " + temp;
        }
    }
    }
