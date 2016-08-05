using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Conditioner : SmartHouse.Temperature
    {
       

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
       
    }
    }
