﻿using EPAM_Cource_1.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Models
{
    class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
