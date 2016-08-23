using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Temperature : AbstractDevice, SmartHouse.IRegulatorTemp
    {
        private  int max;
        private int min;
        private int temp;

        internal Temperature(int max, int min, int temp) 
        {
            this.temp = temp;
            this.max = max;
            this.min = min;
        }

        public int Temp
        {
            get
            {
                return temp;
            }
            set
            {
                if (value <= max && value >= min)
                {
                    temp = value;
                }
            }
        }


        public void DecreaseTemp()
        {
            Temp--;
        }

        public void IncreaseTemp()
        {
            Temp++;
        }
    }
}
    