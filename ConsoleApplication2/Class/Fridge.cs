using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Fridge : SmartHouse.Temperature, IOpenClose
    {


        public Fridge(string name, int min, int max, int temp)
            : base(name, min, max, temp)
        {
            this.temp = temp;
            this.min = min;
            this.max = max;
        }
        public void DecreaseTemp()
        {
            for (; temp > min; temp--)   { }
        }

        public void IncreaseTemp()
        {
            for (; temp < max; temp++) { }
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
