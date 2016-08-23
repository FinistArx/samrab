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
            TV Tv = new TV(117, 50);
            return Tv;
        }

        public MusikCentr CreateMusikCentr() 
        {
          MusikCentr Mc = new MusikCentr( 138, 50 );
          return Mc;
        }

        public Fridge CreateFridge()
        {

            Fridge Fr = new Fridge(10, -20, 0);
            return Fr;      
        }

         public Boiler CreateBoiler()
        {
            Boiler Boil= new Boiler(90, 10, 15);
            return Boil;
         }

           public Conditioner CreateConditioner() 
           {
               Conditioner Cond = new Conditioner(40, 10, 16);
               return Cond;
        }
    }
}
