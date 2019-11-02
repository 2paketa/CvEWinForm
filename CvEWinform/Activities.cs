using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CvECommon;

namespace CvEWinform
{
    class Activities
    {
        private Domains domains;
        Random rng;
        public Activities()
        {
            domains = Domains.getInstance();
            rng = new Random();
        }

        public string getDocsOfDomain(string domain)
        {
            var fulltext = $"{domain} ";
            var randomDocs = domains.getDocs(domain);
            int numberOfDocsPerDomain;
            if (randomDocs.Length < domains.currentNumberOfDocs) { numberOfDocsPerDomain = randomDocs.Length; } else { numberOfDocsPerDomain = domains.currentNumberOfDocs; }
            rng.Shuffle(randomDocs);
            for (int i = 0; i < numberOfDocsPerDomain; i++)
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
            string[] domainsAndDocs = domains;
            rng.Shuffle(domains);
            for (int i = 0; i < domains.Length; i++)
            {
                domainsAndDocs[i] = getDocsOfDomain(domains[i]);
            }
            domainText = domainsAndDocs.ApplyFormatting();
            return domainText;
        }
    }
}
