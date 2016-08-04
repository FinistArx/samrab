using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Temperature : AbstactDevice, SmartHouse.IRegulatorTemp
    {
        public int temp;
        public int Temp
        {
            get { return temp; }
            set
            {
                if (temp >= 10 && temp <= 90)
                {
                    temp = value;
                }
                else
                {
                    Console.WriteLine("Посмотрите инструкцию");
                }
            }
        }

        public void DecreaseTemp()
        {
            for (; temp > 10; temp--)
            {
                if (temp < 10)
                {
                    Console.WriteLine("Посмотрите инструкцию");
                }
            }
        }

        public void IncreaseTemp()
        {
            for (; temp < 40; temp++)
            {
                if (temp > 40)
                {
                    Console.WriteLine("Посмотрите инструкцию");
                }
            }
        }

    }
}
