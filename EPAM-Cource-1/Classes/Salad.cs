using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Cource_1.Models
{
    public class Salad
    {
        public string Name { get; }
        private ICollection<IVegetable> _ingredients;
        public int Calories { get; private set; }
        public Salad(ICollection<IVegetable> vegetables, string name = "UnnamedSalad")
        {
            Name = name;
            _ingredients = vegetables;
            CalculateCalories();
        }

        public ICollection<IVegetable> GetIngredients()
        {
            return _ingredients;
        }

        private void CalculateCalories()
        {
            int calories = 0;
            foreach (var vegetable in _ingredients)
            {
                calories += vegetable.Calories;
            }
            Calories = calories;
        }
    }
}
