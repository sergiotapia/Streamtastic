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

        public static string SanitizeThumbnailUrlTwitchtv(string rawThumbnailUrl, string channelOwner)
        {
            if (rawThumbnailUrl == "http://www-cdn.jtvnw.net/images/0px.gif")
            {
                string owner = channelOwner.ToLower();
                return String.Format("http://static-cdn.jtvnw.net/previews/live_user_{0}-320x240.jpg", owner);
            }

            return rawThumbnailUrl;
        }
    }
}
