using CvECommon;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CvEWinform
{
    public class Library
    {
        public static Dictionary<string, string[]> DomainDict;
        StreamReader sr;
        int maxNumberOfDocs;
        public int MaxNumberOfDocs { get { return maxNumberOfDocs; } }

        private Library()
        {
            var path = @"C:\Users\Manos\source\repos\CvEWinform\CvEWinform\Data\Library.csv";
            sr = new StreamReader(path);
            DomainDict = new Dictionary<string, string[]>();
            setDict();
            setMax();
        }

        private void setDict()
        {
            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    var domain = sr.ReadLine().Trim();
                    var docs = sr.ReadLine().LineToArray();
                    DomainDict.Add(domain, docs);
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

    }
}