using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Menu
    {


        public static void Instruction()
        {
            Console.WriteLine("Температурный режим работы котла 10-90");
            Console.WriteLine("Температура режим работы кондиционера 10-40");
            Console.WriteLine("Температура режим работы холодильника от +5 до -20");
        }
      
        public static void Help()
        {
            Console.WriteLine("Список команд:");
            Console.WriteLine("add NewEquipment");
            Console.WriteLine("del Equipment");
            Console.WriteLine("On Equipment");
            Console.WriteLine("Off Equipment");
            Console.WriteLine("IncreaseTemp Conditioner");
            Console.WriteLine("IncreaseTemp Boiler");
            Console.WriteLine("IncreaseTemp FridgFrizer");
            Console.WriteLine("DecreaseTemp Conditioner");
            Console.WriteLine("DecreaseTemp Boiler");
            Console.WriteLine("DecreaseTemp FridgFrizer");
            Console.WriteLine("IncreaseVolume MusikCent");
            Console.WriteLine("DecreaseVolume MusikCent");
            Console.WriteLine("PreviusChennel MusikCent");
            Console.WriteLine("NextChennel MusikCent");
            Console.WriteLine("IncreaseVolume TV");
            Console.WriteLine("DecreaseVolume TV");
            Console.WriteLine("PreviusChennel TV");
            Console.WriteLine("NextChennel TV");
            Console.WriteLine("Instruction");
            Console.WriteLine("Open FridgFrizer");
            Console.WriteLine("Close FridgFrizer");
            Console.WriteLine("exit");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
        }
     
    }
}
