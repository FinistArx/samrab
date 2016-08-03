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
        public bool state;
        public int currentstate;
        public int CurrentState
        {
            get
            {
                return currentstate;
            }
            set
            {
                currentstate = value;
            }
        }

        public int volume;
        public int TVVolume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }
        public int chennel;
        public int TVChennel
        {
            get
            {
                return chennel;
            }
            set
            {
                chennel = value;
            }
        }

        public void On()
        {
            state = true;
        }

        public void Off()
        {
            state = false;
        }

        public void NextChennel()
        {

            if (chennel < 200)
            {
                chennel++;
            }
        }

        public void PreviusChennel()
        {
            if (chennel > 0)
            {
                chennel--;
            }
        }

        public void DecreaseVolume()
        {
            if (volume > 0)
            {
                volume--;
            }
        }

        public void IncreaseVolume()
        {
            for (; volume < 100; volume++)
            {
                volume++;
            }
        }
    }
}
