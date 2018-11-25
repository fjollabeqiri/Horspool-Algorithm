using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = rtbText.Text;
            string stringPattern = txtPattern.Text;
            List<int> result = HorspoolAlgorithm.Find(myString, stringPattern);
            if (result.Count == 0)
            {
                lblRezultati.Text = "Teksti i kerkuar nuk eshte gjetur.";
            }
            else
            {
                if(result.Count == 1)
                    lblRezultati.Text = "Teksti i kerkuar eshte gjetur ne poziten:\n\n" + result.Last();
                else
                {
                    var pozitat =new StringBuilder();
                    for (int i=0; i < result.Count; i++)
                    {
                        if(i!=result.Count-1)
                            pozitat.Append(result.ElementAt(i)+", ".ToString());
                        else
                            pozitat.Append(result.ElementAt(i).ToString());
                    }
                    lblRezultati.Text = "Teksti i kerkuar eshte gjetur ne pozitat:\n\n" + pozitat;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
