﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading;
using PizzaDremma.enums;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
public static class EnumUtil
{
    public static IEnumerable<T> GetValues<T>()
    {
        return Enum.GetValues(typeof(T)).Cast<T>();
    }
}
namespace PizzaDremma
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mozzarella";
            int quantity = 5;
            Methods methode = new Methods();
            Ingredient ingredient = new Ingredient(name, quantity);
            
            Console.OutputEncoding = Encoding.UTF8;
              /* methode.PrintBanner();
               Console.ReadLine();
             methode.PlayTetris();
               methode.Payment();
            LogWriter.WriteLog(Console.ReadLine());
            Console.ReadLine();
              */
           // Pizza veggie = new Pizza("regular","cheezy");
               
                
        methode.PrintBanner();
            Console.ReadLine();
            ingredient.PrintIngredient();
            
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = methode.PizzariaMenu();
            }

            
            
            
        }
    }
}
