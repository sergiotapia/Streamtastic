using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Streamtastic.Helpers
{
    public static class SanitizeHelper
    {
        public static int SanitizeViewCount(string rawViewCount)
        {
            string b = string.Empty;
            int val = 0;
            for (int i = 0; i < rawViewCount.Length; i++)
            {
                if (Char.IsDigit(rawViewCount[i]))
                    b += rawViewCount[i];
            }
            if (b.Length > 0)
                val = int.Parse(b);

            return val;
        }
    }
}
