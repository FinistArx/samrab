using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IVolume
    {
         int Volume
        {
            get;
            set;
        }

         void DecreaseVolume();
         void IncreaseVolume();

    }
}
