using System;
using System.Globalization;
using System.Linq;

namespace CSharpTestProject.Services
{
    public static class DateHelper
    {
        public static DateTime[] Convert(params string[] stringDates)
        {
            return stringDates.ToList()
                .Select(x => DateTime.ParseExact(x, "ddMMMyyyy(ddd)", CultureInfo.InvariantCulture)).ToArray();
        }
    }
}