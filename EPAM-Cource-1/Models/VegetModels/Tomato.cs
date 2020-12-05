using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models.VegetModels
{
    class Tomato : IVegetable
    {
        public int Calories { get; } = 200;

        public float Protein { get; } = 1.2f;

        public float Fats { get; } = 7.4f;

        public float Carbohydrates { get; } = 5.3f;
        public VegetType Type { get; } = VegetType.Tomato;
    }
}
