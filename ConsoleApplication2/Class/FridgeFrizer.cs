﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class FridgeFrizer : SmartHouse.Temperature, IOpenClose
    {

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


        public  void DecreaseTemp()
        {
            for (; Temp > 10; Temp--)
            {
                if (Temp < 10)
                {
                    Console.WriteLine("Посмотрите инструкцию");
                }
            }
        }

        public  void IncreaseTemp()
        {
            for (; Temp < 40; Temp++)
            {
                if (Temp > 40)
                {
                    Console.WriteLine("Посмотрите инструкцию");
                }
            }
        }


        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
