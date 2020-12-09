using EPAM_Cource_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Cource_1.Classes
{
    public static class SaladExtention
    {
        public static ICollection<IVegetable> GetSortIngredByCalories(this Salad salad) => salad.GetIngredients().OrderBy(item => item.Calories).ToList<IVegetable>();
        public static ICollection<IVegetable> GetSortIngredByFats(this Salad salad) => salad.GetIngredients().OrderBy(item => item.Fats).ToList<IVegetable>();
        public static ICollection<IVegetable> GetSortIngredByCarbohydrates(this Salad salad) => salad.GetIngredients().OrderBy(item => item.Carbohydrates).ToList<IVegetable>();
        public static ICollection<IVegetable> GetSortIngredByProtein(this Salad salad) => salad.GetIngredients().OrderBy(item => item.Protein).ToList<IVegetable>();
        public static ICollection<IVegetable> GetVegetablesInCaloriesRange(this Salad salad, int fromRange, int toRange)
        {
            ICollection<IVegetable> result = new List<IVegetable>();
            foreach (var vegetable in salad.GetIngredients())
            {
                if ((vegetable.Calories >= fromRange) && (vegetable.Calories <= toRange))
                {
                    result.Add(vegetable);
                }
            }
            return result;
        }
    }
}
