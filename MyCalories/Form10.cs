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
    public partial class Form10 : Form
    {
        public Form6 mainForm;
        public Form10(Form6 form)
        {
            InitializeComponent();

            mainForm = form;
            wirklichLoeschenLabel.Font = new Font("Bahnschrift", 20);
        }

        private void jaEntfernBtn_Click(object sender, EventArgs e)
        {
            mainForm.loeschenConfirmed = true;
            mainForm.Activate();
            Dispose();
        }

        private void neinEntfernBtn_Click(object sender, EventArgs e)
        {
            mainForm.loeschenConfirmed = false;
            mainForm.Activate();
            Dispose();
        }
    }
}
