using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Temperature : AbstactDevice, SmartHouse.IRegulatorTemp
    {
        public bool stateonoff;

        bool StateOnOff
        {
            get;
            set;
        }



        public int Temp
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            { }
        }


       

        public void IncreaseTemp()
        {
            throw new NotImplementedException();
        }

        public void DecreaseTemp()
        {
            throw new NotImplementedException();
        }
    }
}
