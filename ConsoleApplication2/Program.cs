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
            
            IDictionary<string , AbstractDevice> NewEquipment = new Dictionary<string, AbstractDevice>();
            Creator creativ = new Creator();
            NewEquipment.Add("Ra", creativ.CreateTV());
            NewEquipment.Add("Pi", creativ.CreateBoiler());
            NewEquipment.Add("i", creativ.CreateConditioner());
            NewEquipment.Add("P", creativ.CreateFridgeFrizer());
            NewEquipment.Add("a", creativ.CreateMusikCentr());

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

                if (commands.Length != 3)
                {
                    Menu.Help();
                    continue;
                }

                if (commands[0].ToLower() == "add" &&  !NewEquipment.ContainsKey(commands[1]))
                {
                    NewEquipment.Add(commands[1], new NewEquipment(commands[1], creativ));
                    continue;
                }

                if (commands[0].ToLower() == "add" && NewEquipment.ContainsKey(commands[1]))
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

                switch (commands[0].ToLower())
                {
                    case "del":
                        NewEquipment.Remove(commands[1]);
                        break;
                    case "add":
                        NewEquipment.Remove(commands[1]);
                        break;

                    case "on":
                        NewEquipment[commands[1]].On();
                        break;


                    case "off":
                        NewEquipment[commands[1]].Off();
                        break;

                    case "cl":
                        if (NewEquipment[commands[0]] is IOpenClose)
                        {
                            ((IOpenClose)NewEquipment[commands[1]]).Close();
                        }
                        break;

                    case "op":
                        if (NewEquipment[commands[0]] is IOpenClose)
                        {
                            ((IOpenClose)NewEquipment[commands[0]]).Open();
                        }
                        break;
                        
                    case "decrT":
                        if (NewEquipment[commands[1]] is IRegulatorTemp)
                        {
                            ((IRegulatorTemp)NewEquipment[commands[1]]).DecreaseTemp();
                        }
                        break;

                    case "incrT":
                        if (NewEquipment[commands[1]] is IRegulatorTemp)
                        {
                            ((IRegulatorTemp)NewEquipment[commands[1]]).IncreaseTemp();
                        }
                        break;             

                    case "incV":
                        if (NewEquipment[commands[1]] is IVolume)
                        {
                            ((IVolume)NewEquipment[commands[0]]).IncreaseVolume();
                        }
                        break;

                    case "decrV":
                        if (NewEquipment[commands[1]] is IVolume)
                        {
                            ((IVolume)NewEquipment[commands[0]]).DecreaseVolume();
                        }
                        break;

                    case "PreviusChennel":
                        if (NewEquipment[commands[0]] is IChangeChennel)
                        {
                            ((IChangeChennel)NewEquipment[commands[0]]).PreviusChennel();
                        }
                        break;

                    case "NextChennel":
                        if (NewEquipment[commands[0]] is IChangeChennel)
                        {
                            ((IChangeChennel)NewEquipment[commands[0]]).NextChennel();
                        }
                        break;

                    case "Instruction":
                        Menu.Instruction();
                        break;

                    default:
                        Menu.Help();
                        break;
                }

            }



        }
    }
}