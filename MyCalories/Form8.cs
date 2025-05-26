using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalories
{
    public partial class Form8 : Form
    {
        public Form1 mainform;
        int sollKals;
        int sollEiws;
        public Form8(Form1 form)
        {
            InitializeComponent();


            this.mainform = form;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            mainform.Activate();
            this.Dispose();
            
        }

        private void sollZutatFinal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(sollKalorienBox.Text, out sollKals))
            {

            }
            else
            {
                MessageBox.Show("bitte eine gültige Zahl angeben");
                return;
            }
            if (int.TryParse(zielEiweißBox.Text, out sollEiws))
            {

            }
            else
            {
                MessageBox.Show("bitte eine gültige Zahl eingeben");
                return;
            }
            mainform.makeSoll(sollKals, sollEiws);
            mainform.Activate();
            this.Dispose();
        }
    }
}
