using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Boiler : SmartHouse.Temperature
    {

           
         public int temp;
         public int Temp
         {
              get { return temp; }
              set 
                {
               if (value >= 10 && value <= 90)
                  {
            temp = value;
                    }
                           else
         {
            throw new Exception("Неверное значение температуры");
         }
              }
         }
       
        public void DecreaseTemp()
        {
            for (; Temp > 10; Temp--) { }
           
        }

        public void IncreaseTemp()
        {
            for (; Temp < 90; Temp++) { }
        }


    }
}
