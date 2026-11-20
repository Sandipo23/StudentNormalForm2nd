using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNormalApp
{
    internal static class DateUtility // this is a static class which is used to store the extension method for DateTime
    {
        public static string FormatDate(this DateTime DOB, string format = Constants.Format) // this is an extension method which is used to format the date
        {
            return DOB.ToString(format); // this is the default format which is used to format the date
        }
    }
}

