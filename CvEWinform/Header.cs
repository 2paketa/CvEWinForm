using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CvECommon;

namespace CvEWinform
{
    class Header
    {
        string[] titles;
        int currentYear;
        int yearsOfExperience;
        int startingYear;
        Random rng;
        
        public Header(int yearsOfExperience)
        {
            rng = new Random();
            this.yearsOfExperience = yearsOfExperience;
            currentYear = DateTime.Now.Year;
            startingYear = currentYear - yearsOfExperience;
            var titlesInstance = Titles.getInstance();
            titles = titlesInstance.getTitles();
        }

        public string Get()
        {
            var title = $"{titles[rng.Next(titles.Length)]}";
            string result;
            if (title.Contains(nameof(startingYear)))
            {
                result = Regex.Replace(title, nameof(startingYear), startingYear.ToString());
            }
            else
            {
                result = Regex.Replace(title, nameof(yearsOfExperience), yearsOfExperience.ToString());
            }
            return result;
        }
    }
}
