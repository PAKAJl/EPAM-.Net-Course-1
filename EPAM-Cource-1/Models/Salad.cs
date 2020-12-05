using System;
using System.Collections.Generic;
using System.Linq;
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
            CalculateCalories();
        }

        public ICollection<IVegetable> SortIngredByCalories()
        {
            var result = ingredients.OrderBy(item => item.Calories);
            return result as ICollection<IVegetable>;
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
