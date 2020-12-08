using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Cource_1.Models
{
    class Salad
    {
        public string Name { get; } = "UnnamedSalad";
        private ICollection<IVegetable> ingredients;
        public int Calories { get; private set; }
        public Salad(ICollection<IVegetable> vegetables, string name)
        {
            Name = name;
            ingredients = vegetables;
            CalculateCalories();
        }
        public Salad(ICollection<IVegetable> vegetables)
        {
            ingredients = vegetables;
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
