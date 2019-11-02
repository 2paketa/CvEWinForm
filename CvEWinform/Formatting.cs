using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvEWinform
{
    static class Formatting
    {
        public static int currentID;
        public static string ApplyFormatting(this string[] items)
        {
            switch (currentID)
            {
                case 1:
                    return CommaSeparated(items);
                default:
                    return BulletPoints(items);
            }
        }

        public static string BulletPoints(string[] items)
        {
            string formattedText = "";
            for (int i = 0; i < items.Length; i++)
            {
               formattedText += $"\u2022 {items[i]} {Environment.NewLine}";
            }
            return formattedText;
        }

        public static string CommaSeparated(this string[] items)
        {
            string formattedText = "";
            for (int i = 0; i < items.Length; i++)
            {
                if (i == 0)
                {
                    formattedText += items[i];
                }
                else
                {
                    formattedText += $", {items[i]}";
                }
                formattedText.Trim(',');
            }
            return formattedText;
        }
    }
}
