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
    public partial class Form7 : Form
    {
        public Form6 mainForm;
        public float kalorien;
        public float eiweiß;
        public float menge;
        public String nameGericht;

        public Form7(Form6 form, float kalorien, float eiweiß, float menge)
        {
            InitializeComponent();
            this.mainForm = form;
            this.kalorien = kalorien;
            this.eiweiß = eiweiß;
            this.menge = menge;

            kategorieComboBox.BackColor = SystemColors.Window;
            kategorieComboBox.ForeColor = Color.Black;
            kategorieComboBox.DataSource = Enum.GetValues(typeof(Zutat.Kategorie));
            kategorieComboBox.SelectedItem = Zutat.Kategorie.Gericht;
            gebrMengeBox.Text = menge.ToString();
        }

        private void closeBtn7_Click(object sender, EventArgs e)
        {
            mainForm.Activate();
            Dispose();
        }

        private void saveChanges7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(gerichtNameBox.Text) && !float.TryParse(gebrMengeBox.Text, out menge))
            {
                MessageBox.Show("bitte einen gültige Werte angeben angeben");
                return;
            }
            else
            { 
                nameGericht = gerichtNameBox.Text;
                menge = float.Parse(gebrMengeBox.Text);
            }
            mainForm.makeGericht(nameGericht, kalorien, eiweiß, menge, (Zutat.Kategorie)kategorieComboBox.SelectedItem);
            mainForm.Activate();
            this.Dispose();
        }
    }
}
