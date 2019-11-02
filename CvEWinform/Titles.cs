using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvEWinform
{
    class Titles: Library
    {
        string[] titles;
        private static Titles instance;

        private Titles()
        {
            var titleLibrary = Path.Combine(Directory.GetCurrentDirectory(), "Data\\titles.csv");
            sr = new StreamReader(titleLibrary);
            Set();
        }

        public static Titles getInstance()
        {
            if (instance == null)
            {
                instance = new Titles();
            }
            return instance;
        }

        public override void Set()
        {
            using (sr)
            {
                if (sr.Peek() == -1)
                {
                    MessageBox.Show("Title Library is empty, please populate it");
                }
                else
                {
                    var listOfTitles = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        listOfTitles.Add(sr.ReadLine());
                    }
                    titles = listOfTitles.ToArray();
                }
            }
        }

        public string[] getTitles()
        {
            return titles;
        }
    }
}
