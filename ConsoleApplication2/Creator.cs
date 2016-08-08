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
            TV Tv = new TV( 117, 50);
            return Tv;
        }

        public MusikCentr CreateMusikCentr() 
        {
          MusikCentr Mc= new MusikCentr( 138, 50 );
          return Mc;
        }

        public FridgeFrizer CreateFridgeFrizer()
        {

            FridgeFrizer FrFr = new FridgeFrizer(-20, 5, 0);
            return FrFr;      
        }

         public Boiler CreateBoiler()
        {
            Boiler Boil= new Boiler(10, 90, 16);
            return Boil;
         }

           public Conditioner CreateConditioner() 
           {
               Conditioner Cond = new Conditioner(10, 40, 14);
               return Cond;
        }
    }
}
