using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Temperature : AbstactDevice, SmartHouse.IRegulatorTemp
    {

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

        public override string ToString()
        {
            int temp;
            if (this.state)
            {
                state = "включен";
            }
            else
            {
                state = "выключен";
            }

            string mode;
            if (this.brightness == BrightnessLevel.Low)
            {
                mode = "слабая";
            }
            else if (this.brightness == BrightnessLevel.Medium)
            {
                mode = "средняя";
            }
            else
            {
                mode = "высокая";
            }

            return "состояние: " + state + ", яркость: " + mode;
        }

    }
}
