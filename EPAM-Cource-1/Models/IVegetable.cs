using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models
{
    interface IVegetable
    {
        public int Calories { get;}
        public float Protein { get; }
        public float Fats { get; }
        public float Carbohydrates { get; }
        public VegetType Type { get; }
    }

    enum VegetType
    {
        Potato,
        Carrot,
        Cucumber,
        Tomato,
        Pepper
    }
}
