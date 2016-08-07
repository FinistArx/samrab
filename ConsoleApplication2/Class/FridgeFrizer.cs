using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class FridgeFrizer : SmartHouse.Temperature, IOpenClose
    {
            
  
          public FridgeFrizer (int min, int max, int temp) : base( min,  max,  temp)
        {
            this.temp = temp;
            this.min = min;
            this.max = max;
        }
            
        public bool state;
        public bool State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public void Open()
        {
            state = true;
        }

        public void Close()
        {
            state = false;
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
