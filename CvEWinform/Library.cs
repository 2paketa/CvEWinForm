using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CvECommon;

namespace CvEWinform
{
    public class Library: IDisposable
    {
        public static Dictionary<string, string[]> DomainDict;
        StreamReader sr;
        int maxNumberOfDocs;
        public int MaxNumberOfDocs { get { return maxNumberOfDocs; } }

        private Library()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data\\Library.csv");
            //var path = @"C:\Users\Manos\source\repos\CvEWinform\CvEWinform\Data\Library.csv";
            sr = new StreamReader(filePath);
            DomainDict = new Dictionary<string, string[]>();
            setDict();
            setMax();
        }

        private void setDict()
        {
            using (sr)
            {
                if (sr.Peek() == -1)
                {
                    MessageBox.Show("Domain library is empty, please populate it");
                }
                else
                {
                    while (!sr.EndOfStream)
                    {
                        var domain = sr.ReadLine().Trim();
                        var docs = sr.ReadLine().LineToArray();
                        DomainDict.Add(domain, docs);
                    }
                }

            }
        }

        private static Library Instance = null;

        public static Library getInstance()
        {
            if (Instance == null)
            {
                Instance = new Library();
            }
            return Instance;
        }

        public string[] getDocs(string domain)
        {
            return DomainDict[domain];
        }

        public bool isInputValid(string[] input)
        {
            var isValid = true;
            foreach (string key in input)
            {
                if (!DomainDict.ContainsKey(key) || key == " ")
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        void setMax()
        {
            foreach(string[] entry in DomainDict.Values)
            {
                if (entry.Length > maxNumberOfDocs)
                {
                    maxNumberOfDocs = entry.Length;
                }
            }
        }

        public void Dispose()
        {
            sr.Close();
        }
    }
}