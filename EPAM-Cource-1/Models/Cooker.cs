using EPAM_Cource_1.Models.VegetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Cource_1.Models
{
    class Cooker
    {
        private Refregerator refregerator = new Refregerator();

        private ICollection<Salad> saladList;
        private ICollection<IVegetable> vegetablesInHand;

        public void CreateSalad(ICollection<IVegetable> vegetables, string name)
        {
            saladList.Add(new Salad(vegetables, name));
        }

        public ICollection<Salad> GetSaladList()
        {
            return saladList;
        }

        public ICollection<IVegetable> GetVegetInRefrege()
        {
            return refregerator.GetVegetableList();
        }

        public ICollection<IVegetable> GetVegetInHandList()
        {
            return vegetablesInHand;
        }

        public void GetVegetToHand(VegetType vegetType)
        {
            vegetablesInHand.Add(refregerator.GetVegetable(vegetType));
        }

        public void SortIngredByCalories(Salad salad)
        {
            var result = salad.GetIngedients().OrderBy(item => item.Calories);
        }
    }
}
