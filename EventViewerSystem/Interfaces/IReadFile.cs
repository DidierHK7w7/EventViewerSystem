using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventViewerSystem.Interfaces
{
    internal interface IReadFile
    {
        string[] ReadFiles(string fileLocation);
    }
}
