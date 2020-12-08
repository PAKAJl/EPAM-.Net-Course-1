using EPAM_Cource_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models.VegetModels
{
    class Carrot : IVegetable
    {
        public string Name { get; } = "Carrot";
        public int Calories { get; } = 180;
        public float Protein { get; } = 18.7f;
        public float Fats { get; } = 1;
        public float Carbohydrates { get; } = 50f;
        public VegetType Type { get; } = VegetType.Carrot;

        
    }
}
