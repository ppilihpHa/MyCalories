using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.Entity;
using System.Globalization;
using static MyCalories.Zutat;
namespace MyCalories
{
    public partial class Form5 : Form
    {
        Form1 mainForm;
        Zutat selectZut;
        Gericht selectGer;
        List<Zutat> inhaltsstoffe;
        BindingList<Zutat> bindListGerInhalte;

        // für query

        public List<Zutat> queryZutProGericht;
        public Gericht queryGericht;
        public List<Gericht> queryGerichteListe;


        public Form5(Form1 form, Zutat zutat)
        {
            InitializeComponent();


            mainForm = form;
            rezeptGrid.Visible = false;
            selectZut = zutat;
            setUp();
        }

        public Form5(Form1 form, Zutat zutat, Gericht gericht)
        {
            InitializeComponent();


            mainForm = form;
            selectZut = zutat;
            using (var context = new MyCaloriesDbContext())
            {
                selectGer = context.Gerichts.Find(gericht.GerichtId);
            }
            setUp2();
        }

        public void setUp()
        {
            //closeBtn5.Location = new Point(closeBtn5.Location.X - 235, closeBtn5.Location.Y);
            //saveChanges.Location = new Point(saveChanges.Location.X - 235, saveChanges.Location.Y);
            this.Size = new Size(500, 320);

            zutatNameBox5.Text = selectZut.name;
            zutatKalorienBox5.Text = selectZut.kalorien.ToString();
            eiweißZutatBox5.Text = selectZut.eiweiß.ToString();
            zutatGewichtBox5.Text = selectZut.gewicht.ToString();
            
            kategorieComboBox.BackColor = SystemColors.Window;
            kategorieComboBox.ForeColor = Color.Black;
            kategorieComboBox.DataSource = Enum.GetValues(typeof(Zutat.Kategorie));
            kategorieComboBox.SelectedItem = selectZut.kategorie;
        }
        public void setUp2()
        {
            rezeptGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rezeptGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rezeptGrid.ReadOnly = true;

            rezeptGrid.Font = new Font("Bahnschrift", 16);
            rezeptGrid.DefaultCellStyle.ForeColor = Color.Black;

            kategorieComboBox.BackColor = SystemColors.Window;
            kategorieComboBox.ForeColor = Color.Black;
            kategorieComboBox.DataSource = Enum.GetValues(typeof(Zutat.Kategorie));
            kategorieComboBox.SelectedItem = selectZut.kategorie;

            Color color = new Color();
            color = Color.FromArgb(56, 142, 60);

            rezeptGrid.GridColor = color;
            rezeptGrid.DefaultCellStyle.BackColor = color;
            rezeptGrid.ColumnHeadersDefaultCellStyle.BackColor = color;
            rezeptGrid.BackgroundColor = color;

            rezeptGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            rezeptGrid.AllowUserToOrderColumns = false;
            rezeptGrid.AllowUserToResizeColumns = false;
            rezeptGrid.AllowUserToResizeRows = true;

            rezeptGrid.AutoGenerateColumns = false;

            zutatNameBox5.Text = selectZut.name;
            zutatKalorienBox5.Text = selectZut.kalorien.ToString();
            eiweißZutatBox5.Text = selectZut.eiweiß.ToString();
            zutatGewichtBox5.Text = selectZut.gewicht.ToString();

            setUp2DataGrid();

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "ZutatName";
            nameColumn.Name = "Zutat";
            rezeptGrid.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn mengeColumn = new DataGridViewTextBoxColumn();
            mengeColumn.DataPropertyName = "menge";
            mengeColumn.Name = "Menge";
            rezeptGrid.Columns.Add(mengeColumn);

            this.Invalidate();
        }

        public void setUp2DataGrid()
        {
            using (var context = new MyCaloriesDbContext())
            {
                var zutatenListe = context.GerichtZutats
                .Where(gz => gz.GerichtId == selectGer.GerichtId)
                .Select(gz => new
                {
                    ZutatName = gz.Zutat.name,
                    Menge = gz.menge
                }).ToList();

                rezeptGrid.DataSource = zutatenListe;
            }
            this.Invalidate();
        }

        public void setUp2DataGrid2(float kalos, int mengo, float eiwo)
        {
            zutatKalorienBox5.Text = kalos.ToString();
            zutatGewichtBox5.Text = mengo.ToString();
            eiweißZutatBox5.Text = eiwo.ToString();

            setUp2DataGrid();
        }

        private void closeBtn5_Click(object sender, EventArgs e)
        {
            mainForm.Activate();
            Dispose();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            using (var context = new MyCaloriesDbContext())
            {
                float kals;
                float eiws;
                int gew;

                Zutat selectZut2 = context.Zutaten.Find(selectZut.ZutatId);

                selectZut2.name = zutatNameBox5.Text;

                if (float.TryParse(zutatKalorienBox5.Text, out kals))
                {
                    selectZut2.kalorien = kals;
                }
                else
                {
                    MessageBox.Show("bitte eine gültige Zahl angeben");
                    return;
                }
                if (float.TryParse(eiweißZutatBox5.Text, out eiws))
                {
                    selectZut2.eiweiß = eiws;
                }
                else
                {
                    MessageBox.Show("bitte eine gültige Zahl angeben");
                    return;
                }
                if (int.TryParse(zutatGewichtBox5.Text, out gew))
                {
                    selectZut2.gewicht = gew;
                }
                else
                {
                    MessageBox.Show("bitte eine gültige Zahl angeben");
                    return;
                }
                selectZut2.kategorie = (Zutat.Kategorie)kategorieComboBox.SelectedItem;

                context.Entry(selectZut2).State = System.Data.Entity.EntityState.Modified;


                context.SaveChanges();
            }
            mainForm.Activate();
            mainForm.changeDataSrc();
            this.Dispose();
        }

        // querying 

        public void queryingGerichte()
        {
            using (var context = new MyCaloriesDbContext())
            {
                IQueryable<Gericht> queryGerichte = context.Gerichts
                    .Include(g => g.GerichtZutats);
                queryGerichteListe = queryGerichte.ToList();
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            mainForm.changeDataSrc();
            using (var context = new MyCaloriesDbContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var zuLöschendeZutat = context.Zutaten.FirstOrDefault(z => z.name == selectZut.name);

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

        private void zutsBearbeiten_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6(this, selectGer);
            form.ShowDialog();
            //evtl noch disposen
        }
    }
}
