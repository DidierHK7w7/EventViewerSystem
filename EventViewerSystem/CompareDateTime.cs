using EventViewerSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventViewerSystem
{
    internal class CompareDateTime
    {
        private int minutes, hours, days, months;
        public void compareDateTimes(string nameEvent, DateTime dateValues, TimeSpan dateDifference)
        {
            string eventStatus = nameEvent;
            if (dateValues < DateTime.Now)
            {
                eventStatus += " ocurrio hace:";
            }
            else
            {
                dateDifference = dateValues - DateTime.Now;
                eventStatus += " ocurrira dentro de:";
            }
            ConvertAllToMinutes(eventStatus, dateDifference);
        }

        private void ConvertAllToMinutes(string eventStatus, TimeSpan dateDifference)
        {
            DateConvert dateConvert = new DateConvert();

            minutes = (int)dateDifference.TotalMinutes;
            hours = dateConvert.MinuteToHour(minutes);
            days = dateConvert.HourToDays(hours);
            months = dateConvert.DaysToMonths(days);

            PrintConvertedEventDates printConvertedEventDates = new PrintConvertedEventDates();
            printConvertedEventDates.compareConvertedDates(eventStatus, minutes, hours, days, months);
        }
    }
}
