using EPAM_Cource_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models.VegetModels
{
    class Tomato : IVegetable
    {
        public string Name { get; }
        public int Calories { get; }
        public float Protein { get; }
        public float Fats { get; }
        public float Carbohydrates { get; }
        public VegetType Type { get; }

        public Tomato()
        {
            Name = "Tomato";
            Calories = 200;
            Protein = 1.2f;
            Fats = 7.4f;
            Carbohydrates = 5.3f;
            Type = VegetType.Carrot;
        }
    }
}
