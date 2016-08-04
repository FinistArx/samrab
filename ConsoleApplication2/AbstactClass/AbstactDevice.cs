using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class AbstactDevice
    {
        public bool state;

         public AbstactDevice(bool state)
         {
             this.state = state;
         }
        public void On()
        {
            state = true;
        }

        public void Off()
        {
            state = false;
        }
        
        
    }
}
