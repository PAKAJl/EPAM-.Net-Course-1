using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models
{
    class Cucumber : IVegetable
    {
        public int Calories { get; } = 130;
        public float Protein { get; } = 12.1f;
        public float Fats { get; } = 2;
        public float Carbohydrates { get; } = 22f;
        public VegetType Type { get; } = VegetType.Cucumber;
    }
}
