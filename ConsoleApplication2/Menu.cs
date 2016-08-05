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
            Console.WriteLine("Температура режим работы холодильника от +5 до -15");
            Console.WriteLine("Температура режим работы морзилки от 0 до (-20)");
        }
      
        public static void Help()
        {
            Console.WriteLine("Список команд:");
            Console.WriteLine("add_NewEquipment");
            Console.WriteLine("del_Equipment");
            Console.WriteLine("On_Equipment");
            Console.WriteLine("Off Equipment");
            Console.WriteLine("IncreaseTemp Conditioner");
            Console.WriteLine("DecreaseTemp Conditioner");
            Console.WriteLine("IncreaseVolume");
            Console.WriteLine("DecreaseVolume");
            Console.WriteLine("SetVolume");
            Console.WriteLine("SetChennel");
            Console.WriteLine("PreviusChennel");
            Console.WriteLine("NextChennel");
            Console.WriteLine("Instruction");
            Console.WriteLine("Open");
            Console.WriteLine("Close");
            Console.WriteLine("exit");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
        }
     
    }
}
