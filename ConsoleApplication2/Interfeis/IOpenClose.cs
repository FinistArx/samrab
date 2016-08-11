using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IOpenClose
    {
        bool StateOpenClose
        {            get;            set;        }
    
        void Open();

        void Close();
    }
}
