using EPAM_Cource_1.Models.VegetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Cource_1.Models
{
    class Cooker
    {
        private ICollection<Salad> saladList = new List<Salad>();
        private ICollection<IVegetable> vegetables = new List<IVegetable>();

        public void CreateSalad(ICollection<IVegetable> vegetables, string name)
        {
            saladList.Add(new Salad(vegetables, name));
        }
        public void CreateSalad(ICollection<IVegetable> vegetables)
        {
            saladList.Add(new Salad(vegetables));
        }
        public ICollection<Salad> GetSaladList()
        {
            return saladList;
        }
        public ICollection<IVegetable> GetVegetablesList()
        {
            return vegetables;
        }
        public ICollection<IVegetable> GetSortIngredByCalories()
        {
            return vegetables.OrderBy(item => item.Calories).ToList<IVegetable>();
        }
        public ICollection<IVegetable> GetSortIngredByFats()
        {
            return vegetables.OrderBy(item => item.Fats).ToList<IVegetable>();
        }
        public ICollection<IVegetable> GetSortIngredByCarbohydrates()
        {
            return vegetables.OrderBy(item => item.Carbohydrates).ToList<IVegetable>();
        }
        public ICollection<IVegetable> GetSortIngredByProtein()
        {
            return vegetables.OrderBy(item => item.Protein).ToList<IVegetable>();
        }
        public IVegetable GetVegetable(VegetType vegetType) 
        {
            IVegetable current = vegetables.FirstOrDefault(vegetable => vegetable.Type == vegetType);
            vegetables.Remove(current);
            return current;
        }
        public void AddVegetable(ICollection<IVegetable> vegetableList)
        {
            foreach (var item in vegetableList)
            {
                vegetables.Add(item);
            }
        }
        public ICollection<IVegetable> GetVegetablesInCaloriesRange(int fromRange, int toRange)
        {
            ICollection<IVegetable> result = new List<IVegetable>();  
            foreach ( var vegetable in vegetables)
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
