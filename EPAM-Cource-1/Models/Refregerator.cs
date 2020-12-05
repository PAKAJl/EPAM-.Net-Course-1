using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models.VegetModels
{
    class Refregerator
    {
        private ICollection<IVegetable> vegetables;

        public Refregerator()
        {
        }

        public Refregerator(ICollection<IVegetable> vegetables)
        {
            this.vegetables = vegetables;
        }

        public ICollection<IVegetable> GetVegetableList()
        {
            return vegetables;
        }

        public IVegetable GetVegetable(VegetType vegetType)
        {
            IVegetable vegetResult = null;
            foreach (var veget in vegetables)
            {
                if (veget.Type == vegetType)
                {
                    vegetResult = veget;
                    vegetables.Remove(veget);
                    break;
                }
            }
            return vegetResult;
        }

        public void AddVegetable(IVegetable vegetable)
        {
            vegetables.Add(vegetable);
        }
    }
}
