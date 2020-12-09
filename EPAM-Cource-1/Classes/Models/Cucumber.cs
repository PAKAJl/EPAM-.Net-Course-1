using EPAM_Cource_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models
{
    class Cucumber : IVegetable
    {
        public string Name { get; }
        public int Calories { get; } 
        public float Protein { get; } 
        public float Fats { get; } 
        public float Carbohydrates { get; } 
        public VegetType Type { get; }
        public Cucumber()
        {
            Name = "Cucumber";
            Calories = 130;
            Protein = 12.1f;
            Fats = 2;
            Carbohydrates = 22f;
            Type = VegetType.Cucumber;
        }
    }
}
