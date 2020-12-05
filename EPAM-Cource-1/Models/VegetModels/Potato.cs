using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models.VegetModels
{
    class Potato : IVegetable
    {
        public int Calories { get; } = 350;
        public float Protein { get; } = 40.1f;
        public float Fats { get; } = 6;
        public float Carbohydrates { get; } = 60f;
    }
}
