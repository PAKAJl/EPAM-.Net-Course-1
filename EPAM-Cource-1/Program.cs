using EPAM_Cource_1.Classes;
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

        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            Cooker cooker = new Cooker();
            logger.Log("Приготорление салата...");
            List<IVegetable> ingredients = new List<IVegetable>();
            ingredients.Add(new Carrot());
            ingredients.Add(new Potato());
            ingredients.Add(new Pepper());
            ingredients.Add(new Tomato());
            ingredients.Add(new Cucumber());
            ingredients.Add(new Pepper());
            cooker.CreateSalad(ingredients, "Мимоза");
            logger.Log("Салат мимоза создан. Калорийность равна:");
            Salad currentSalad = cooker.GetSaladList().FirstOrDefault(saladItem => saladItem.Name == "Мимоза");
            logger.Log(currentSalad.Calories.ToString());
            logger.Log("Продукты отсортированы по калорийности:");
            LogCollection(currentSalad.GetSortIngredByCalories());
            logger.Log("Продукты отсортированы по кол-ву белков:");
            LogCollection(currentSalad.GetSortIngredByProtein());
            logger.Log("Продукты отсортированы по кол-ву жиров:");
            LogCollection(currentSalad.GetSortIngredByFats());
            logger.Log("Продукты отсортированы по кол-ву углеводов:");
            LogCollection(currentSalad.GetSortIngredByCarbohydrates());
            logger.Log("Овощи по в калорийном диапазоне от 100ед. до 190ед.");
            LogCollection(currentSalad.GetVegetablesInCaloriesRange(100, 190));
            
        }
    }
}
