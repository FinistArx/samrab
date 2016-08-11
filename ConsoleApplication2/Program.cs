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
            NewEquipment.Add("MC", creativ.CreateMusikCentr());
            NewEquipment.Add("Fr1", creativ.CreateFridge());
            NewEquipment.Add("t", creativ.CreateTV());


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

                if (commands[0].ToLower() == "add" && !NewEquipment.ContainsKey(commands[2]))
                {
                    switch (commands[1])
                    {
                        case "boiler":
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
                if (commands[0].ToLower() == "del" && NewEquipment.ContainsKey(commands[2]))
                {
                    switch (commands[1])
                    {
                        case "boiler":
                            NewEquipment.Remove(commands[2]);
                            break;
                        case "cond":
                            NewEquipment.Remove(commands[2]);
                            break;
                        case "mcentr":
                            NewEquipment.Remove(commands[2]);
                            break;
                        case "fridge":
                            NewEquipment.Remove(commands[2]);
                            break;
                        case "tv":
                            NewEquipment.Remove(commands[2]);
                            break;
                    }
                }
                if (commands[0] == "on" && NewEquipment.ContainsKey(commands[2]))
                {
                    if(NewEquipment[commands[1]] is AbstractDevice)
                        {
                            ((AbstractDevice)NewEquipment[commands[2]]).On();
                        }
                    break;
                }

                if (commands[0] == "off" && NewEquipment.ContainsKey(commands[2]))
                {
                    if (NewEquipment[commands[1]] is AbstractDevice)
                    {
                        ((AbstractDevice)NewEquipment[commands[2]]).Off();
                    }
                    break;
                }

                        case "close":
                            if (NewEquipment[commands[1]] is IOpenClose)
                            {
                                ((IOpenClose)NewEquipment[commands[1]]).Close();
                            }
                            break;

                        case "open":
                            if (NewEquipment[commands[1]] is IOpenClose)
                            {
                                ((IOpenClose)NewEquipment[commands[1]]).Open();
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

                        case "I":
                            Menu.Instruction();
                            break;

                        default:
                            Menu.Help();
                            break;
                    }

                }



            }
        }