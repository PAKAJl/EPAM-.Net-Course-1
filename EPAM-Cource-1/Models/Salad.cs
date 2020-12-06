using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Cource_1.Models
{
    class Salad
    {
        public string LogText { get; } = "Salad";
        private ICollection<IVegetable> ingredients;
        public int Calories { get; private set; }

        public Salad(ICollection<IVegetable> vegetables, string name)
        {
            LogText = name;
            ingredients = vegetables;
            CalculateCalories();
        }

        public ICollection<IVegetable> GetIngedients()
        {
            return ingredients;
        }

        public void AddIngredient(IVegetable vegetable)
        {
            ingredients.Add(vegetable);
            CalculateCalories();
        }

        private void CalculateCalories()
        {
            int calories = 0;
            foreach (var vegetable in ingredients)
            {
                calories += vegetable.Calories;
            }
            Calories = calories;
        }
    }
}
