using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CvECommon;

namespace CvEWinform
{
    public class MainBody
    {
        public int YearsOfExperience { get; set; }
        public int startingYear { get { return currentYear - YearsOfExperience; } }
        static int currentYear = DateTime.Now.Year;
        public int NumberOfDocs { get; set; }
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

        private string title()
        {
            string[] titles = { $"Freelance translator since {startingYear}", $"Working as a freelance translator since {startingYear}", $"Translator for {YearsOfExperience} years" };
            rng.Shuffle(titles);
            return titles[0];
        }

        public string getMainBodyText(string[] domains)
        {
            string finalText = $"{title()}";
            finalText += Environment.NewLine;
            finalText += getDomains(domains);
            return finalText;
        }


    }
}