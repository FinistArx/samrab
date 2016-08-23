using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Fridge : SmartHouse.Temperature, IOpenClose
    {
        private int max = 10;
        private int min = -20;
        private int temp;

        internal Fridge(int max, int min, int temp)
            : base( max,  min, temp)
        {
            this.temp = temp;
            this.max = max;
            this.min = min;
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
