using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models
{
    class Salad
    {
        public ICollection<IVegetable> ingredients;
        public int Calories { get; private set; }

        public Salad(ICollection<IVegetable> vegetables)
        {
            ingredients = vegetables;
            Calories = CalculateCalories();
        }

        private int CalculateCalories()
        {
            int calories = 0;
            foreach (var vegetable in ingredients)
            {
                calories += vegetable.Calories;
            }
            return calories;
        }
    }
}
