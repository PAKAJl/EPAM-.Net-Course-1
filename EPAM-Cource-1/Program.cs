using EPAM_Cource_1.Interfaces;
using EPAM_Cource_1.Models;
using EPAM_Cource_1.Models.VegetModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EPAM_Cource_1
{
    class Program
    {
        private static ICollection<IVegetable> BuyProducts()
        {
            ICollection<IVegetable> cart = new List<IVegetable>();
            cart.Add(new Potato());
            cart.Add(new Carrot());
            cart.Add(new Pepper());
            cart.Add(new Tomato());
            cart.Add(new Pepper());
            cart.Add(new Cucumber());
            cart.Add(new Carrot());
            cart.Add(new Potato());
            return cart;
        }
        private static void LogCollection(ICollection<IVegetable> collection)
        {
            ILogger logger = new ConsoleLogger();
            int i = 1;
            foreach (var item in collection)
            {
                logger.Log($"{i}."+item.Name);
                i++;
            }
        }
        private static void LogCollection(ICollection<Salad> collection)
        {
            ILogger logger = new ConsoleLogger();
            int i = 1;
            foreach (var item in collection)
            {
                logger.Log($"{i}." + item.Name);
                i++;
            }
        }
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            Cooker cooker = new Cooker();
            logger.Log("Повар пришел на работу!");
            cooker.AddVegetable(BuyProducts());
            logger.Log("Продукты куплены.");
            logger.Log("Приготорление салата...");
            List<IVegetable> ingredients = new List<IVegetable>();
            ingredients.Add(cooker.GetVegetable(VegetType.Carrot));
            ingredients.Add(cooker.GetVegetable(VegetType.Potato));
            ingredients.Add(cooker.GetVegetable(VegetType.Cucumber));
            cooker.CreateSalad(ingredients, "Мимоза");
            logger.Log("Салат мимоза создан. Калорийность равна:");
            logger.Log(cooker.GetSaladList().FirstOrDefault(saladItem => saladItem.Name == "Мимоза").Calories.ToString());
            logger.Log("Продукты отсортированы по калорийности:");
            LogCollection(cooker.GetSortIngredByCalories());
            logger.Log("Продукты отсортированы по кол-ву белков:");
            LogCollection(cooker.GetSortIngredByProtein());
            logger.Log("Продукты отсортированы по кол-ву жиров:");
            LogCollection(cooker.GetSortIngredByFats());
            logger.Log("Продукты отсортированы по кол-ву углеводов:");
            LogCollection(cooker.GetSortIngredByCarbohydrates());
            logger.Log("Овощи по в калорийном диапазоне от 100ед. до 190ед.");
            LogCollection(cooker.GetVegetablesInCaloriesRange(100, 190));
            
        }
    }
}
