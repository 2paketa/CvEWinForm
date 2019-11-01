using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CvECommon;

namespace CvEWinform
{
    public class MainBody
    {
        public int NumberOfDocs { get; set; }
        public int YearsOfExperience { get; set; }
        private Library library;
        Random rng;
        public MainBody()
        {
            library = Library.getInstance();
            rng = new Random();
        }
        
        public string getDocsOfDomain(string domain)
        {
            var fulltext = $"{domain} ";
            var randomDocs = library.getDocs(domain);
            int numberOfCurrentDocs;
            if (randomDocs.Length < NumberOfDocs) { numberOfCurrentDocs = randomDocs.Length; } else { numberOfCurrentDocs = NumberOfDocs; }
            rng.Shuffle(randomDocs);
            for (int i = 0; i < numberOfCurrentDocs; i++)
            {
                if (i == 0)
                    fulltext += $"({randomDocs[i]}";
                else 
                    fulltext += $", {randomDocs[i]}";
            }
            fulltext += ")";
            return fulltext;
        }
        

        public string getDomains(string[] domains)
        {
            string domainText = "";
            rng.Shuffle(domains);
            for (int i = 0; i < domains.Length; i++)
            {
                if (i == 0)
                    domainText += getDocsOfDomain(domains[i]);
                else
                    domainText += $", {getDocsOfDomain(domains[i])}";
            }
            domainText.Trim(',');
            return domainText;
        }

        public string getMainBodyText(string[] domains)
        {
            Header header = new Header(YearsOfExperience);
            string finalText = $"{header.Get()}";
            finalText += Environment.NewLine;
            finalText += getDomains(domains);
            return finalText;
        }


    }
}