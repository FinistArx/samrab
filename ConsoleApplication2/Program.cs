using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {

            IDictionary<string, AbstractDevice> NewEquipment = new Dictionary<string, AbstractDevice>();
            Creator creativ = new Creator();
            NewEquipment.Add("mc", creativ.CreateMusikCentr());
            NewEquipment.Add("fr", creativ.CreateFridge());
            NewEquipment.Add("t", creativ.CreateTV());
            NewEquipment.Add("c", creativ.CreateConditioner());
            NewEquipment.Add("b", creativ.CreateBoiler());

            while (true)
            {

                Console.Clear();
                foreach (var newtemp in NewEquipment)
                {
                    Console.WriteLine("Название: " + newtemp.Key + ", " + newtemp.Value.ToString());
                }
                Console.WriteLine();
                Console.Write("Введите команду: ");

                string[] commands = Console.ReadLine().Split(' ');

                if (commands[0].ToLower() == "exit" & commands.Length == 1)
                {
                    return;
                }

                if (commands[0].ToLower() == "add" && !NewEquipment.ContainsKey(commands[2]))
                {
                    switch (commands[1])
                    {
                        case "boil":
                            NewEquipment.Add(commands[2], creativ.CreateBoiler());
                            break;
                        case "cond":
                            NewEquipment.Add(commands[2], creativ.CreateConditioner());
                            break;
                        case "mcentr":
                            NewEquipment.Add(commands[2], creativ.CreateMusikCentr());
                            break;
                        case "fridge":
                            NewEquipment.Add(commands[2], creativ.CreateFridge());
                            break;
                        case "tv":
                            NewEquipment.Add(commands[2], creativ.CreateTV());
                            break;
                    }
                    continue;
                }

                if (commands[0].ToLower() == "add" && NewEquipment.ContainsKey(commands[2]))
                {
                    Console.WriteLine("Устройство с таким именем уже существует");
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                    continue;
                }

                if (!NewEquipment.ContainsKey(commands[1]))
                {
                    Menu.Help();
                    continue;
                }

                if (commands[0].ToLower() == "del" && NewEquipment.ContainsKey(commands[1]))
                {
                    NewEquipment.Remove(commands[1]);
                    continue;
                }

                if (commands[0] == "on" && NewEquipment.ContainsKey(commands[1]))
                {
                        NewEquipment[commands[1]].On();
                        continue;
                }

                if (commands[0] == "off" && NewEquipment.ContainsKey(commands[1]))
                {
                        NewEquipment[commands[1]].Off();
                        continue; 
                }

                if (commands[0] == "close" && NewEquipment.ContainsKey(commands[1]))
                {
                    ((IOpenClose)NewEquipment[commands[1]]).Close();
                    continue; 
                }

                if (commands[0] == "open" && NewEquipment.ContainsKey(commands[1]))
                {
                        ((IOpenClose)NewEquipment[commands[1]]).Open();
                    continue; 
                }

                if (commands[0] == "det" && NewEquipment.ContainsKey(commands[1]))
                {
                        ((IRegulatorTemp)NewEquipment[commands[1]]).DecreaseTemp();
                    continue;
                }

                if (commands[0] == "int" && NewEquipment.ContainsKey(commands[1]))
                {
                        ((IRegulatorTemp)NewEquipment[commands[1]]).IncreaseTemp();
                    continue; 
                }

                if (commands[0] == "inV" && NewEquipment.ContainsKey(commands[1]))
                {
                        ((IVolume)NewEquipment[commands[1]]).IncreaseVolume();
                    continue; 
                }

                if (commands[0] == "deV" && NewEquipment.ContainsKey(commands[1]))
                {
                        ((IVolume)NewEquipment[commands[1]]).DecreaseVolume();
                    continue; 
                }

                if (commands[0] == "prCh" && NewEquipment.ContainsKey(commands[1]))
                {

                        ((IChangeChennel)NewEquipment[commands[1]]).PreviusChennel();
                    continue; 
                }

                if (commands[0] == "nextCh" && NewEquipment.ContainsKey(commands[1]))
                {
                        ((IChangeChennel)NewEquipment[commands[1]]).NextChennel();
                    continue; 
                }

                if (commands[0].ToLower() == "In" & commands.Length == 1)
                {
                    Menu.Instruction();
                    continue; 
                }

            }
        }
    }
}