using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IOpenClose
    {
        bool State
        {
            get;
            set;
        }
    
        void Open();

        void Close();
    }
}
