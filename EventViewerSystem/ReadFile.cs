using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventViewerSystem.Interfaces;

namespace EventViewerSystem
{
    internal class ReadFile : IReadFile
    {
        public string[] ReadFiles(string fileLocation)
        {
            string[] events = File.ReadAllLines(fileLocation);
            return events;
        }
    }
}
