using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IRegulatorTemp
    {

        int Temp
        {
            get;
            set;
        }
    
        void IncreaseTemp();

        void DecreaseTemp();
    }
}
