using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Creator
    {
        public TV CreateTV()
        {
            TV Tv = new TV();
            return Tv;
        }

        public MusikCentr CreateMusikCentr() 
        {
          MusikCentr Mc= new MusikCentr();
          return Mc;
        }

        public FridgeFrizer CreateFridgeFrizer()
        {

            FridgeFrizer FrFr = new FridgeFrizer();
            return FrFr;      
        }

         public Boiler CreateBoiler()
        {
            Boiler Boil= new Boiler();
            return Boil;
         }

           public Conditioner CreateConditioner() 
           {
               Conditioner Cond = new Conditioner();
               return Cond;
        }
    }
}
