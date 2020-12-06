using EPAM_Cource_1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Cource_1.Interfaces
{
    interface ILogger
    {
        public void WriteText(string text);

        public void WriteCollection(ICollection<ILogged> collection);
    }
}
