using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MyCalories
{
    public partial class Form2 : Form
    {

        Form1 mainForm;
        Zutat zutat;

        public Form2(Form1 mForm)
        {
            
            InitializeComponent();

            mainForm = mForm;
            kategorieComboBox.BackColor = SystemColors.Window;
            kategorieComboBox.ForeColor = Color.Black;
            kategorieComboBox.DataSource = Enum.GetValues(typeof(Zutat.Kategorie));
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AddZutatFinal_Click(object sender, EventArgs e)
        {
            float kals;
            float eiw;
            int gew;

            if (float.TryParse(zutatKalorienBox.Text, out kals) && float.TryParse(eiweißZutatBox.Text, out eiw) && int.TryParse(zutatGewichtBox.Text, out gew))
            {
                zutat = new Zutat
                {
                    name = zutatNameBox.Text,
                    kalorien = kals,
                    eiweiß = eiw,
                    gewicht = gew,
                    kategorie = (Zutat.Kategorie)kategorieComboBox.SelectedItem
                };

                using (var context = new MyCaloriesDbContext())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    context.Zutaten.Add(zutat);
                    context.SaveChanges();
                }

                mainForm.changeDataSrc();
                mainForm.Activate();
                this.Dispose();
            }
            else 
            {
                MessageBox.Show("Bitte gültige Werte angeben");
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            mainForm.Activate();
            this.Dispose();
        }

        private void zutatGewichtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                AddZutatFinal.PerformClick();
            }
        }

        private void eiweißZutatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                AddZutatFinal.PerformClick();
            }
        }

        private void zutatKalorienBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                AddZutatFinal.PerformClick();
            }
        }
    }
}
