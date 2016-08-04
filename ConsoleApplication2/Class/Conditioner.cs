using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Conditioner : SmartHouse.Temperature
    {
        
        public int temp;
        public int Temp
        {
            get { return temp; }
            set
            {
                if (value >= 10 && value <= 90)
                {
                    temp = value;
                }
                else
                {
                        Console.WriteLine("Посмотрите инструкцию");
                }
            }
        }

        public void DecreaseTemp()
        {
            for (; Temp > 10; Temp--) 
            {
                if (Temp < 10)
                {
                    Console.WriteLine("Посмотрите инструкцию");
                }
            }
        }

        public void IncreaseTemp()
        {
            for (; Temp < 40; Temp++)
            {
            if (Temp > 40)
            {
                Console.WriteLine("Посмотрите инструкцию");
            }
            }
        }
  
            

         int Temp
        {
            get { return temp; }
            set
            {
                int temp = Int32.Parse(Console.ReadLine());
                if (temp >= 10 && temp <= 90)
                {                                   
                    temp = value;
                }
                else
                {
                    Console.WriteLine("Посмотрите инструкцию");
                }
            }
        }
        string stateopenclose ;
        public string Stateopenclose;
        {
            get
            {
                return stateopenclose;
            }
            set
            {
                if (this.stateopenclose)
                   {
                    stateopenclose = "открыто";
                    }
            else
                    {
                    stateopenclose = "закрыто"
                    }
                    stateopenclose = value;
                    }

    }
    
