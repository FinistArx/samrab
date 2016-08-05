using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class AbstractDevice
    {
        public bool State
        {
            get;
            set;
        }
       
         public void On() { }
         public void Off() { }
    }

    public class TV : SmartHouse.VolumeChennel
    {

    
    }
}
