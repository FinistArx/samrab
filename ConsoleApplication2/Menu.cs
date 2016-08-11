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
            Console.WriteLine("add NewEquipment + имя");
            Console.WriteLine("del Equipment + имя");
            Console.WriteLine("On Equipment + имя ");
            Console.WriteLine("Off Equipment + имя");
            Console.WriteLine("IncreaseTemp Equipment + имя ");
            Console.WriteLine("DecreaseTemp Equipment + имя ");
            Console.WriteLine("IncreaseVolume Equipment + имя");
            Console.WriteLine("DecreaseVolume Equipment + имя");
            Console.WriteLine("PreviusChennel Equipment + имя");
            Console.WriteLine("NextChennel Equipment + имя");
            Console.WriteLine("IncreaseVolume Equipment + имя");
            Console.WriteLine("DecreaseVolume Equipment + имя");
            Console.WriteLine("PreviusChennel Equipment + имя");
            Console.WriteLine("NextChennel Equipment + имя");
            Console.WriteLine("Instruct");
            Console.WriteLine("Open Equipment + имя");
            Console.WriteLine("Сlose Equipment + имя");
            Console.WriteLine("exit");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
        }
     
    }
}
