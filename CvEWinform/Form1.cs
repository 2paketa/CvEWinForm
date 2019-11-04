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
    public partial class Form1 : Form
    {
        private MainBody mainbody;
        private Domains domains;
        string[] desiredDomains;
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Data"));
            var domainsLibrary = Path.Combine(Directory.GetCurrentDirectory(), "Data\\domains.csv");
            using (var stream = File.Open(domainsLibrary, FileMode.OpenOrCreate))
            {
            }
            domains = Domains.getInstance();
            numericDoc.Maximum = domains.MaxNumberOfDocs;
            getText.Enabled = false;
            label5.Text = "";
        }

        private void getText_Click(object sender, EventArgs e)
        {
            Run();
            label5.Text = "";
        }

        private void numericDoc_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericYearExp_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Run()
        {
            mainbody = new MainBody();
            domains.currentNumberOfDocs = (int)numericDoc.Value;
            mainbody.YearsOfExperience = (int)numericYearExp.Value;
            desiredDomains = selectedDomains.Text.LineToArray();
            finalText.Text = mainbody.Get(desiredDomains);
            desiredDomains = null;
            mainbody = null;
        }

        private void commaSeparated_CheckedChanged(object sender, EventArgs e)
        {
            if (commaSeparated.Checked) { Formatting.currentID = 1; }
        }

        private void bulletPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (bulletPoints.Checked) { Formatting.currentID = 2; }
        }

        private void None_CheckedChanged(object sender, EventArgs e)
        {
            if (random.Checked) { Formatting.currentID = 0; }
        }

        private void selectedDomains_TextChanged(object sender, EventArgs e)
        {

            if (selectedDomains.Text.LineToArray().GroupBy(x => x).Any(g => g.Count() > 1))
            {
                label5.Text = "Please remove duplicate values";
                getText.Enabled = false;
            }
            else if (domains.isInputValid(selectedDomains.Text.LineToArray()))
            {
                label5.Text = "Input is valid";
                label5.ForeColor = Color.Green;
                getText.Enabled = true;
            }
            else
            {
                label5.Text = "Please insert at least one valid domain or more separated by comma and space";
                label5.ForeColor = Color.Red;
                getText.Enabled = false;
            }
        }
    }
}
