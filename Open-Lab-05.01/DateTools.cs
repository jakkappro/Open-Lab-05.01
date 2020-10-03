using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            int ret = year % 100 == 0 ? year / 100 : year / 100 +1;

            string sret = ret.ToString();

            if(ret == 11 || ret == 12)
                return sret + "th century";

            if (sret.ToCharArray()[sret.Length - 1] == '1')
            {
                return sret + "st century";
            }
            if (sret.ToCharArray()[sret.Length - 1] == '2')
            {
                return sret + "nd century";
            }
            if (sret.ToCharArray()[sret.Length - 1] == '3')
            {
                return sret + "rd century";
            }

            return sret + "th century";
        }
    }
}
