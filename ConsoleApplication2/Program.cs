﻿using System;
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

            NewEquipment.Add("Рулетка", creativ.CreateBoiler());

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

                if (commands.Length != 2)
                {
                    Menu.Help();
                    continue;
                }

                if (commands[0].ToLower() == "add" && NewEquipment.ContainsKey(commands[1]))
                {
                    NewEquipment.Add(commands[1], creativ.CreateTV());
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

                switch (commands[0].ToLower())
                {
                    case "del":
                        NewEquipment.Remove(commands[1]);
                        break;

                    case "on":
                        NewEquipment[commands[1]].On();
                        break;

                    case "off":
                        NewEquipment[commands[1]].Off();
                        break;

                    case "close":
                        if (NewEquipment[commands[1]] is IOpenClose)
                        {
                            ((IOpenClose)NewEquipment[commands[0]]).Close();
                        }
                        break;

                    case "open":
                        if (NewEquipment[commands[1]] is IOpenClose)
                        {
                            ((IOpenClose)NewEquipment[commands[0]]).Open();
                        }
                        break;
                        
                    case "DecreaseTemp":
                        if (NewEquipment[commands[1]] is IRegulatorTemp)
                        {
                            ((IRegulatorTemp)NewEquipment[commands[1]]).DecreaseTemp();
                        }
                        break;

                    case "IncreaseTemp":
                        if (NewEquipment[commands[1]] is IRegulatorTemp)
                        {
                            ((IRegulatorTemp)NewEquipment[commands[1]]).IncreaseTemp();
                        }
                        break;             

                    case "IncreaseVolume":
                        if (NewEquipment[commands[0]] is IVolume)
                        {
                            ((IVolume)NewEquipment[commands[0]]).IncreaseVolume();
                        }
                        break;

                    case "DecreaseVolume":
                        if (NewEquipment[commands[0]] is IVolume)
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