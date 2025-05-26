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
    public partial class Form3 : Form
    {
        public Form1 mainForm;
        public List<Zutat> zutatenListe = new List<Zutat>();
        public Form3(Form1 form, List<Zutat> liste)
        {
            InitializeComponent();
            mainForm = form;
            zutatenListe = liste;
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            mainForm.Activate();
            this.Dispose();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            mainForm.changeDataSrc();
            using (var context = new MyCaloriesDbContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var zuLöschendeZutat = context.Zutaten.FirstOrDefault(z => z.name == zutatDelNameBox.Text);

                if (zuLöschendeZutat != null)
                {
                    context.Zutaten.Remove(zuLöschendeZutat);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("bitte eine gültige Zutat angeben");
                    return;
                }
            }

            mainForm.changeDataSrc();
            mainForm.Activate();
            this.Dispose();
        }
    }
}
