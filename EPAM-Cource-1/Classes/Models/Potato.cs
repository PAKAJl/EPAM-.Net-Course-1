using EPAM_Cource_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models.VegetModels
{
    class Potato : IVegetable
    {
        public string Name { get; }
        public int Calories { get; }
        public float Protein { get; }
        public float Fats { get; }
        public float Carbohydrates { get; }
        public VegetType Type { get; }

        public Potato()
        {
            Name = "Potato";
            Calories = 350;
            Protein = 40.1f;
            Fats = 6;
            Carbohydrates = 60f;
            Type = VegetType.Potato;
        }
    }
}
