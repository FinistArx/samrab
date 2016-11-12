using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class MusikCentr : AbstractDevice, IChangeChennel, IVolume
    {
        public MusikCentr( int chennel, int volume)
        {

            this.volume = volume;
            this.chennel = chennel;

        }

        private int chennel;
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

        private int volume;
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
                Chennel++;
            }
        }

        public void PreviusChennel()
        {
            if (chennel > 0)
            {
                Chennel--;
            }
        }

        public void DecreaseVolume()
        {
            if (volume > 0)
            {
                Volume--;
            }
        }

        public void IncreaseVolume()
        {
            if (volume <100)
            {
                Volume++;
            }
        }



                public override string ToString()
        {
            string state;
            if (this.state)
            {
                state = "включен";
            }
            else
            {
                state = "выключен";
            }


            return "состояние: " + state + ", текущая громкость: " + Volume + "текущий канал " + Chennel ;
        }

    }
}