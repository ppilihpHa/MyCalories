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
using System.Data.SqlTypes;

namespace MyCalories
{
    public partial class Form1 : MaterialForm
    {

        //merken: Update-Database -TargetMigration:0
        //Add-Migration MigrationName
        //Update-Database

        public List<Zutat> zutatenListe = new List<Zutat>();  
        public List<Tag> tageListe = new List<Tag>();
        public List<Tag> nurHeuteListe = new List<Tag>();

        public Soll aktSoll;

        BindingList<Anzeige> bindListe = new BindingList<Anzeige>();

        public List<Label> labels = new List<Label>();
        public List<Rechnung> rechnungen = new List<Rechnung>();
        public Timer timer;
        public int aktuelleLaenge = 0;
        public Form1 form1;
        public Form2 form2;
        public Form3 form3;
        public Form4 form4;
        public Form6 form6;

        public bool hinzuAbbgebrochen = false;

        DateTime rechnerZeit;
        Tag tag;
        DateTime zeitpunktFuerTag;

        public float rechnenCal;
        public float rechnenEiw;
        public float rechnenMenge;

        Color color = new Color();

        //Kategorie filtern 

        public bool isFiltered = false;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            Color primary1 = Color.FromArgb(76, 175, 80);
            Color primary2 = Color.FromArgb(56, 142, 60);
            Color primary3 = Color.FromArgb(144, 238, 144);
            Color accent1 = Color.FromArgb(255, 235, 59);
            Color textShade1 = Color.FromArgb(255);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(primary1,primary2,primary3,accent1,TextShade.BLACK);

            //Primary, Primary.Blue600, Primary.Green600, Accent.LightBlue200, TextShade.BLACK
            //Primary: Color.FromArgb(76, 175, 80),   // #4CAF50
            //PrimaryDark: Color.FromArgb(56, 142, 60), // #388E3C
            //Accent: Color.FromArgb(255, 235, 59),     // #FFEB3B
            //TextShade: 255
            form1 = this;
            menuBoardSet();
            tagRechnerSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addZutat_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this);

            form2.Show();
        }

        public void setRechnerZeit()
        {
            rechnerZeit = DateTime.Today;
        }
        public void timerS()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick;

            timer.Start();
        }

        public void tagRechnerSet()
        {
            changeDataSrcRech();
        }

        public void menuBoardSet()
        {
            using (var context = new MyCaloriesDbContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                zutatenListe = context.Zutaten.ToList();
                BindingList<Zutat> bindingZutatenListe = new BindingList<Zutat>(zutatenListe);
                menuBoard.DataSource = bindingZutatenListe;
            }

            setRechnerZeit();

            menuBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuBoard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            menuBoard.ReadOnly = true;

            menuBoard.Font = new Font("Bahnschrift", 16);
            menuBoard.DefaultCellStyle.ForeColor = Color.Black;

            suchLabel.Font = new Font("Bahnschrift", 16);
            gesamtLabel.Font = new Font("Bahnschrift", 16);
            gesamtLabel2.Font = new Font("Bahnschrift", 16);
            datumLabel.Font = new Font("Bahnschrift", 16);
            zielLabel.Font = new Font("Bahnschrift", 16);
            zielEiwLabel.Font = new Font("Bahnschrift", 16);

            color = Color.FromArgb(56, 142, 60);

            kategorieComboBox.BackColor = SystemColors.Window;
            kategorieComboBox.ForeColor = Color.Black;
            kategorieComboBox.DataSource = Enum.GetValues(typeof(Zutat.Kategorie));
            kategorieComboBox.Font = new Font("Bahnschrift", 20);
            kategorieComboBox.Size = new Size(283, 60);

            isFilteredCheckBox.Checked = false;
            isFilteredCheckBox.Font = new Font("Bahnschrift", 20);
            isFilteredCheckBox.AutoSize = false;

            progressBar.ForeColor = Color.Black;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Height = 50;

            progressBarEiw.ForeColor = Color.Black;
            progressBarEiw.Style = ProgressBarStyle.Blocks;
            progressBarEiw.MarqueeAnimationSpeed = 0;
            progressBarEiw.Height = 50;

            addZutat.BackColor = color;

            menuBoard.Columns["Tags"].Visible = false;
            menuBoard.Columns["ZutatId"].Visible = false;
            menuBoard.Columns["name"].Visible = false;
            menuBoard.Columns["eiweiß"].Visible = false;
            menuBoard.Columns["kalorien"].Visible = false;
            menuBoard.Columns["gewicht"].Visible = false;
            menuBoard.Columns["GerichtZutats"].Visible = false;
            menuBoard.Columns["kategorie"].Visible = false;

            menuBoard.GridColor = color;
            menuBoard.DefaultCellStyle.BackColor = color;
            menuBoard.ColumnHeadersDefaultCellStyle.BackColor = color;
            menuBoard.BackgroundColor = color;

            menuBoard.CellBorderStyle = DataGridViewCellBorderStyle.None;
            menuBoard.AllowUserToOrderColumns = false; 
            menuBoard.AllowUserToResizeColumns = false; 
            menuBoard.AllowUserToResizeRows = true;
            menuBoard.AllowUserToAddRows = false;

            tagRechner.AutoGenerateColumns = false;
            tagRechner.AllowUserToAddRows = false;
            menuBoard.AutoGenerateColumns = false;

            //Colums für TagRechner

            DataGridViewTextBoxColumn datumColumn = new DataGridViewTextBoxColumn();
            datumColumn.DataPropertyName = "Zeitpunkt";
            datumColumn.Name = "Datum";
            tagRechner.Columns.Add(datumColumn);

            DataGridViewTextBoxColumn zutatColumn = new DataGridViewTextBoxColumn();
            zutatColumn.DataPropertyName = "ZutatName";
            zutatColumn.Name = "Zutat";
            tagRechner.Columns.Add(zutatColumn);

            DataGridViewTextBoxColumn calColumn = new DataGridViewTextBoxColumn();
            calColumn.DataPropertyName = "TagZuCal";
            calColumn.Name = "Kalorien";
            tagRechner.Columns.Add(calColumn);

            DataGridViewTextBoxColumn eiwColumn = new DataGridViewTextBoxColumn();
            eiwColumn.DataPropertyName = "TagZuEiw";
            eiwColumn.Name = "Eiweiß";
            tagRechner.Columns.Add(eiwColumn);

            DataGridViewTextBoxColumn mengeColumn = new DataGridViewTextBoxColumn();
            mengeColumn.DataPropertyName = "TagZuMenge";
            mengeColumn.Name = "Menge";
            tagRechner.Columns.Add(mengeColumn);

            tagRechner.Columns["Datum"].DefaultCellStyle.Format = "HH:mm";
            tagRechner.Columns["Eiweiß"].DefaultCellStyle.Format = "N1";
            tagRechner.Columns["Kalorien"].DefaultCellStyle.Format = "N1";

            tagRechner.Sort(tagRechner.Columns["Datum"], ListSortDirection.Ascending);

            // Columns menuBoard

            DataGridViewTextBoxColumn zutatColumnMenu = new DataGridViewTextBoxColumn();
            zutatColumnMenu.DataPropertyName = "name";
            zutatColumnMenu.Name = "Zutat";
            menuBoard.Columns.Add(zutatColumnMenu);

            DataGridViewTextBoxColumn calColumnMenu = new DataGridViewTextBoxColumn();
            calColumnMenu.DataPropertyName = "kalorien";
            calColumnMenu.Name = "Kalorien";
            menuBoard.Columns.Add(calColumnMenu);

            DataGridViewTextBoxColumn eiwColumnMenu = new DataGridViewTextBoxColumn();
            eiwColumnMenu.DataPropertyName = "eiweiß";
            eiwColumnMenu.Name = "Eiweiß";
            menuBoard.Columns.Add(eiwColumnMenu);

            DataGridViewTextBoxColumn mengColumnMenu = new DataGridViewTextBoxColumn();
            mengColumnMenu.DataPropertyName = "gewicht";
            mengColumnMenu.Name = "Menge";
            menuBoard.Columns.Add(mengColumnMenu);

            // Coloums Ende


            tagRechner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            zutatColumn.Width = 250;
            zutatColumnMenu.Width = 300;

            tagRechner.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tagRechner.ReadOnly = true;

            tagRechner.Font = new Font("Bahnschrift", 16);
            tagRechner.DefaultCellStyle.ForeColor = Color.Black;

            tagRechner.GridColor = color;
            tagRechner.DefaultCellStyle.BackColor = color;
            tagRechner.ColumnHeadersDefaultCellStyle.BackColor = color;
            tagRechner.BackgroundColor = color;

            tagRechner.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tagRechner.AllowUserToOrderColumns = false;
            tagRechner.AllowUserToResizeColumns = false;
            tagRechner.AllowUserToResizeRows = true;

        }

        public Zutat getZutatFromID(int id)
        {
            foreach (Zutat elem in zutatenListe)
            {
                if (elem.ZutatId == id)
                { 
                    return elem;
                }
            }
            return null;
        }

        public void changeDataSrc()
        {
            using (var context = new MyCaloriesDbContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                zutatenListe = context.Zutaten.ToList();
                BindingList<Zutat> neueBindingListe = new BindingList<Zutat>(zutatenListe);
                menuBoard.DataSource = neueBindingListe;
            }

            gesamtAnpassen();
            this.Invalidate();
        }

        public void changeDataSrcRech()
        {
            using (var context = new MyCaloriesDbContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                tageListe = context.Tags.Include(t => t.Zutat).OrderByDescending(e => e.Zeitpunkt).ToList();
                nurHeuteListe = tageListe.Where(t => t.Zeitpunkt.Date == rechnerZeit.Date).ToList();
                tagRechner.DataSource = nurHeuteListe;
            }
            gesamtAnpassen();
            this.Invalidate();
        }
        
        public bool isInBindListe(DateTime zeit)
        {
            foreach (Anzeige elem in bindListe)
            {
                if (elem.datum == zeit)
                {
                    return true;
                }
            }
            return false;
        }

        private void TimerTick(object sender, EventArgs e)
        {

        }

        public void gesamtAnpassen()
        {
            float sumCal = 0;
            float sumEiw = 0;
            foreach (Tag elem in nurHeuteListe)
            {
                sumCal = sumCal + elem.TagZuCal;
                sumEiw = sumEiw + elem.TagZuEiw;
            }
            sumCal = (float)Math.Round(sumCal, 0);
            sumEiw = (float)Math.Round(sumEiw, 0);
            gesamtLabel.Text = "kCal-Gesamt: " + sumCal;
            gesamtLabel2.Text = "Eiweiß-Gesamt: " + sumEiw;

            int sumKalProgress = (int)Math.Round(sumCal);
            int sumEiwProgress = (int)Math.Round(sumEiw);

            using (var context = new MyCaloriesDbContext())
            {
                List<Soll> solls = context.Solls.ToList();
                Soll selSoll;
                if (solls.Count > 0)
                {
                    solls = solls.Where<Soll>(s => s.datum.Date == rechnerZeit.Date).ToList();
                    if (solls.Count > 0)
                    {
                        selSoll = solls[0];
                        progressBar.Maximum = selSoll.sollKalorien;
                        progressBar.Value = Math.Min( sumKalProgress, progressBar.Maximum);
                        progressBarEiw.Maximum = selSoll.sollEiweiß;
                        progressBarEiw.Value = Math.Min(sumEiwProgress, progressBarEiw.Maximum);
                        zielLabel.Text = "Max Kal: " + selSoll.sollKalorien;
                        zielEiwLabel.Text = "Eiw: " + selSoll.sollEiweiß;
                    }
                    else
                    {
                        Soll neuesterSoll = context.Solls
                          .OrderByDescending(s => s.datum)  
                          .FirstOrDefault();
                        selSoll = neuesterSoll;
                        progressBar.Maximum = selSoll.sollKalorien;
                        progressBar.Value = Math.Min(sumKalProgress, progressBar.Maximum);
                        progressBarEiw.Maximum = selSoll.sollEiweiß;
                        progressBarEiw.Value = Math.Min(sumEiwProgress, progressBarEiw.Maximum);
                        zielLabel.Text = "Max Kal: " + selSoll.sollKalorien;
                        zielEiwLabel.Text = "Eiw: " + selSoll.sollEiweiß;
                    }
                }
                else
                {
                    progressBar.Visible = false;
                    progressBarEiw.Visible = false;
                    zielEiwLabel.Visible = false;
                    zielLabel.Visible = false;
                }
                
            }

            datumLabel.Text = "Datum: " + rechnerZeit.ToString("dd.MM");

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void menuBoard_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        private void addMahlzeit_Click(object sender, EventArgs e)
        {
            form6 = new Form6(this, 0);

            form6.ShowDialog();
        }

        public void rechnen(float cals, float eiw, int menge, DateTime zeit)
        {
            rechnenCal = cals;
            rechnenEiw = eiw;
            rechnenMenge = menge;
            zeitpunktFuerTag = zeit;
        }

        private void sucheBox_TextChanged(object sender, EventArgs e)
        {

            string eingabe = sucheBox.Text.ToLower();

            if (string.IsNullOrEmpty(eingabe))
            {
                this.changeDataSrc();
            }
            else 
            {
                var query = zutatenListe.Where(z => z.name.ToLower().Contains(eingabe)).ToList();

                menuBoard.DataSource = query;
                this.Invalidate();
            }
        }

        private void datumPlus_Click(object sender, EventArgs e)
        {
            rechnerZeit = rechnerZeit.AddDays(1);
            changeDataSrcRech();
        }

        private void datumMinus_Click(object sender, EventArgs e)
        {
            rechnerZeit = rechnerZeit.AddDays(-1);
            changeDataSrcRech();
        }

        public bool isIn(string nameX, List<String> listY)
        {
            if (listY.Contains(nameX))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void menuBoard_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex < 0)
                {

                }
                else
                {
                    Zutat selectedZutat = (Zutat)menuBoard.Rows[e.RowIndex].DataBoundItem;
                    Gericht selectedGericht;
                    using (var context = new MyCaloriesDbContext())
                    {
                        List<Gericht> gerichte = context.Gerichts.Include(g => g.GerichtZutats).ToList();
                        List<Gericht> selectedGerichtList = gerichte.Where(g => g.name == selectedZutat.name).ToList();
                        
                        if (selectedGerichtList.Count > 0)
                        {
                            selectedGericht = selectedGerichtList[0];
                            Form5 form = new Form5(this, selectedZutat, selectedGericht);

                            form.ShowDialog();
                        }
                        else
                        {
                            Form5 form = new Form5(this, selectedZutat);

                            form.ShowDialog();
                        }

                        
                    }
                }
            }
            else
            {
                if (e.RowIndex < 0)
                {

                }
                else
                {
                    Zutat selectedZutat = (Zutat)menuBoard.Rows[e.RowIndex].DataBoundItem;
                    form4 = new Form4(this, 0);
                    form4.welcheZutatBox.Text = selectedZutat.name;
                    form4.ShowDialog();
                    if (hinzuAbbgebrochen)
                    {
                        hinzuAbbgebrochen = false;
                        return;
                    }
                    else
                    {

                        using (var context = new MyCaloriesDbContext())
                        {
                            context.Configuration.LazyLoadingEnabled = false;
                            var richtigeZutat = context.Zutaten.FirstOrDefault(zutat => zutat.ZutatId == selectedZutat.ZutatId);
                            tag = new Tag
                            {
                                Zeitpunkt = zeitpunktFuerTag,
                                TagZuCal = rechnenCal,
                                TagZuEiw = rechnenEiw,
                                TagZuMenge = rechnenMenge,
                                ZutatId = richtigeZutat.ZutatId,
                                Zutat = richtigeZutat
                            };


                            context.Tags.Add(tag);
                            context.SaveChanges();
                        }
                    }
                    changeDataSrcRech();
                }
            }
        }

        public bool isEnumName<TEnum>(string name) where TEnum : Enum
        {
            foreach (var elem in Enum.GetNames(typeof(TEnum)))
            {
                if (elem.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }


        private void isFilteredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sucheBox.Text = "";
            if (!isFiltered)
            {
                isFiltered = true;

                Zutat.Kategorie kat = (Zutat.Kategorie)kategorieComboBox.SelectedItem;
                var query = zutatenListe.Where(z => z.kategorie == kat).ToList();
                menuBoard.DataSource = query;
                this.Invalidate();
            }
            else if (isFiltered)
            {
                isFiltered = false;

                changeDataSrc();
            }
        }

        private void kategorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //isFilteredCheckBox.Checked = !isFilteredCheckBox.Checked; 
            //isFilteredCheckBox.Checked = !isFilteredCheckBox.Checked;

            isFilteredCheckBox.Checked = false;
            isFilteredCheckBox.Checked = true;
        }

        private void sucheBox_Click(object sender, EventArgs e)
        {
            isFilteredCheckBox.Checked = false;
        }

        private void tagRechner_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Tag selectedTag = (Tag)tagRechner.Rows[e.RowIndex].DataBoundItem;
            Form9 form = new Form9(form1, selectedTag);
            form.ShowDialog();
        }

        private void sollBtn_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(form1);
            form8.ShowDialog();
        }

        public void makeSoll(int kals, int eiws)
        {
            using (var context = new MyCaloriesDbContext())
            {
                List<Soll> solls = context.Solls.ToList();
                solls = solls.Where<Soll>(s => s.datum.Date == DateTime.Now.Date).ToList();
                if (solls.Count > 0)
                {
                    Soll selSoll = context.Solls.Find(solls[0].SollId);
                    selSoll.sollKalorien = kals;
                    selSoll.sollEiweiß = eiws;
                    context.SaveChanges();
                }
                else
                {
                    Soll soll = new Soll
                    {
                        datum = DateTime.Now,
                        sollKalorien = kals,
                        sollEiweiß = eiws,
                    };
                    context.Solls.Add(soll);
                }
                progressBar.Visible = true;
                progressBarEiw.Visible = true;
                zielLabel.Visible = true;
                zielEiwLabel.Visible = true;
                context.SaveChanges();
            }
            gesamtAnpassen();
        }
    }
}
