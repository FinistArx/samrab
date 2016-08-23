using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Temperature : AbstractDevice, SmartHouse.IRegulatorTemp
    {
        private  int max;
        private int min;
        private int temp;

        internal Temperature(int max, int min, int temp) 
        {
        }
        
        public  int Temp
        { get; set; }
           
        public void DecreaseTemp()
        {        }

        public  void  IncreaseTemp()
        {        }
    }
}
    