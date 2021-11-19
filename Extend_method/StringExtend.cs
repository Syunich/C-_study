using System;

namespace CsStudy1
{
    //class which included extend method must need to be static.
    public static class StringExtend
    {
        //extend method is need to "this" keyword. in this case , Reverse is defined in string.
        public static string SyunichReverse(this string str)
        {
            if(string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            char[] strArray = str.ToCharArray();
            Array.Reverse(strArray);
            return new string(strArray);
        }
    }
}
