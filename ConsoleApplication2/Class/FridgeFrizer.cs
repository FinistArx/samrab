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

          public bool stateopenclose;
        public bool StateOpenClose
        {
            get
            {
                return stateopenclose;
            }
            set
            {
                stateopenclose = value;
            }
        }

        public void Open()
        {
            stateopenclose = true;
        }

        public void Close()
        {
            stateopenclose = false;
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
            string stateopenclose;
            if (this.stateopenclose)
            {
                stateopenclose = "открыта";
            }
            else
            {
                stateopenclose = "закрыта";
            }


            return "состояние: " + state + ", температура:  " + Temp + ", дверь " + stateopenclose;
        }

    }
}
