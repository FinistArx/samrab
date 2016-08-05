using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IChangeChennel
    {
        int Chennel
        {
            get;
            set;
        }

        void NextChennel();

        void PreviusChennel();
    }
}
