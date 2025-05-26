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
    public partial class Form9 : Form
    {
        public Form1 mainForm;
        public Tag selectedTag;
        public Form9(Form1 form, Tag selTag)
        {
            InitializeComponent();

            this.mainForm = form;
            selectedTag = selTag;
            neueMenge.Font = new Font("Bahnschrift", 20);
        }

        private void closeBtn5_Click(object sender, EventArgs e)
        {
            mainForm.Activate();
            this.Dispose();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            using (var context = new MyCaloriesDbContext())
            {
                int neueMenge;
                selectedTag = context.Tags.Find(selectedTag.TagId);
                if (int.TryParse(neueMengeBox.Text, out neueMenge))
                {
                    float neueKals1G = (float) (selectedTag.TagZuCal / selectedTag.TagZuMenge);
                    float neueEiw1G = (float) (selectedTag.TagZuEiw / selectedTag.TagZuMenge);

                    float neueKals = neueKals1G * neueMenge;
                    float neueEiw = neueEiw1G * neueMenge;

                    selectedTag.TagZuCal = (float)Math.Round(neueKals, 1);
                    selectedTag.TagZuEiw = (float)Math.Round(neueEiw, 1);
                    selectedTag.TagZuMenge = neueMenge;
                }
                else
                {
                    MessageBox.Show("bitte eine gültige Menge angeben");
                    return;
                }
                context.SaveChanges();
            }
            mainForm.changeDataSrcRech();
            mainForm.Activate();
            this.Dispose();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            using (var context = new MyCaloriesDbContext())
            {
                selectedTag = context.Tags.Find(selectedTag.TagId);
                context.Tags.Remove(selectedTag);
                context.SaveChanges();
            }
            mainForm.changeDataSrcRech();
            mainForm.Activate();
            this.Dispose();
        }

        private void neueMengeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                saveChanges.PerformClick();
            }
        }
    }
}
