using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventViewerSystem.Interfaces
{
    internal interface IDateConverter
    {
        int MinuteToHour(int minutes);
        int HourToDays(int hours);
        int DaysToMonths(int days);
    }
}
