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
        static Dictionary<string, string[]> DomainDict;
        StreamReader domainReader;
        StreamReader titleReader;
        static string[] titles;
        int maxNumberOfDocs;
        public int MaxNumberOfDocs { get { return maxNumberOfDocs; } }

        private Library()
        {
            var domainLibrary = Path.Combine(Directory.GetCurrentDirectory(), "Data\\domains.csv");
            var titleLibrary = Path.Combine(Directory.GetCurrentDirectory(), "Data\\titles.csv");
            //var path = @"C:\Users\Manos\source\repos\CvEWinform\CvEWinform\Data\Library.csv";
            domainReader = new StreamReader(domainLibrary);
            titleReader = new StreamReader(titleLibrary);
            DomainDict = new Dictionary<string, string[]>();
            setDict();
            setTitles();
            setMaxNumberOfDocs();
        }

        private void setDict()
        {
            using (domainReader)
            {
                if (domainReader.Peek() == -1)
                {
                    MessageBox.Show("Domain library is empty, please populate it");
                }
                else
                {
                    while (!domainReader.EndOfStream)
                    {
                        var domain = domainReader.ReadLine().Trim();
                        var docs = domainReader.ReadLine().LineToArray();
                        DomainDict.Add(domain, docs);
                    }
                }

            }
        }

        private void setTitles()
        {
            using (titleReader)
            {
                if (titleReader.Peek() == -1)
                {
                    MessageBox.Show("Title Library is empty, please populate it");
                }
                else
                {
                    var listOfTitles= new List<string>();
                    while (!titleReader.EndOfStream)
                    {
                        listOfTitles.Add(titleReader.ReadLine());
                    }
                    titles = listOfTitles.ToArray();
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

        void setMaxNumberOfDocs()
        {
            foreach(string[] entry in DomainDict.Values)
            {
                if (entry.Length > maxNumberOfDocs)
                {
                    maxNumberOfDocs = entry.Length;
                }
            }
        }

        public string[] getTitles()
        {
            return titles;
        }

        public void Dispose()
        {
            domainReader.Close();
            titleReader.Close();
        }
    }
}