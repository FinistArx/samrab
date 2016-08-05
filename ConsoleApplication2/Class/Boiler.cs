using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Boiler : SmartHouse.Temperature
    {

        public  void DecreaseTemp()
        {
            for (; Temp > 10; Temp--) { }
           
        }

        public  void IncreaseTemp()
        {
            for (; Temp < 90; Temp++) { }
        }


    }
}
