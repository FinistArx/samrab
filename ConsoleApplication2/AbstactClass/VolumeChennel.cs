using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class VolumeChennel : AbstactDevice, IChangeChennel, IVolume
    {
        public int chennel;
        public int Chennel
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

        public int volume;
        public int Volume
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
