using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class AbstractDevice
    {
        public bool state;
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
