using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Boiler : Temperature
    {
        private int max ;
        private int min;
        private int temp;
        internal Boiler(int max, int min, int temp)
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

        internal void DecreaseTemp()
        {
            if (temp > min)
            {
                temp--;
                Console.WriteLine("dddd");
            }

        }

        internal void IncreaseTemp()
        {
            if (temp < max)
            {
                temp++;
                Console.WriteLine("dd");
            }
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

            return "состояние: " + state + ", температура:" + " " + Temp;
        }
    }
}