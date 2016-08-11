﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Temperature : AbstractDevice, SmartHouse.IRegulatorTemp
    {
        public string name;
        protected  int max;
        protected  int min;
        public int temp; 
        
        public Temperature (string name, int min, int max, int temp)
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
                if (value <= max && value >= min)
                {
                    temp = value;
                }
            }
        }
 
        public  int Max
        {
            get
            {
                return max;
            }

        }

        public  int Min
        {
            get
            {
                return min;
            }

        }


        public void DecreaseTemp()
        {
            for (; Temp > Min ; Temp--) 
            { }

        }

        public  void  IncreaseTemp()
        {
            for (; Temp < Max ; Temp++) { }
        }
    }
}
    