using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalories
{
    public partial class Form11 : Form
    {
        public Form6 mainForm;
        int neueMenge;

        public Form11(Form6 form, int wertFText)
        {
            InitializeComponent();

            mainForm = form;
            wieVielBox.Text = wertFText.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(wieVielBox.Text, out neueMenge))
            {
                mainForm.mengeBearb = neueMenge;
                mainForm.Activate();
                Dispose();
            }
            else
            {
                MessageBox.Show("bitte eine gültige Ganzzahl als Menge angeben");
                return;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            mainForm.Activate();
            Dispose();
        }
    }
}
