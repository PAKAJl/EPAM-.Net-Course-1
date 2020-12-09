using EPAM_Cource_1.Models.VegetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Cource_1.Models
{
    class Cooker
    {
        private ICollection<Salad> _saladList = new List<Salad>();

        public void CreateSalad(ICollection<IVegetable> vegetables, string name)
        {
            _saladList.Add(new Salad(vegetables, name));
        }
        public ICollection<Salad> GetSaladList()
        {
            return _saladList;
        }
    }
}
