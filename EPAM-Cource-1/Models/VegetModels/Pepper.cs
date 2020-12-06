using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models.VegetModels
{
    class Pepper: IVegetable
    {
        public string LogText { get; } = "Pepper";
        public int Calories { get; } = 30;
        public float Protein { get; } = 12.1f;
        public float Fats { get; } = 1;
        public float Carbohydrates { get; } = 40f;
        public VegetType Type { get; } = VegetType.Pepper;
    }
}
