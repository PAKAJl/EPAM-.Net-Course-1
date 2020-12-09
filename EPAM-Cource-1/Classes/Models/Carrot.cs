using EPAM_Cource_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models.VegetModels
{
    class Carrot : IVegetable
    {
        public string Name { get; }
        public int Calories { get; }
        public float Protein { get; }
        public float Fats { get; }
        public float Carbohydrates { get; }
        public VegetType Type { get; }

        public Carrot()
        {
            Name = "Carrot";
            Calories = 180;
            Protein = 18.7f;
            Fats = 1;
            Carbohydrates = 50f;
            Type = VegetType.Carrot;
        }

        
    }
}
