using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyCalories
{
    public partial class Form6 : Form
    {
        public Form1 mainform;
        public Form5 mainform2;
        public Form6 thisForm;
        public List<Zutat> zutListe = new List<Zutat> ();
        public List<Zutat> listFuerGerichtZutaten = new List<Zutat>();
        public List<int> listFuerGerichtMengen = new List<int> ();
        public BindingList<Zutat> bindList;
        public BindingList<Anzeige> bindListRechts = new BindingList<Anzeige>();
        Zutat selectedZutat;
        public List<Zutat> auswahl;
        public Form4 form4;
        public int mengeA = 0;
        public float kalorien;
        public float eiweiß;
        public DateTime lueckenFueller = DateTime.MinValue;
        private int modus; // 0 ist normal, 1 kommt beim bearbeiten
        public Gericht selGericht;

        Gericht wahrersGericht;
        List<Zutat> dataSrc;
        List<GerichtZutat> gersZuts;

        //für löschen Abfrage

        public bool loeschenConfirmed = false;

        public Form6(Form1 form, int modusWert)
        {
            InitializeComponent();

            thisForm = this;
            mainform = form;
            modus = modusWert;
            if (modus == 0)
            {
                setUp();
            }
        }

        public Form6(Form5 form, Gericht gericht)
        {
            InitializeComponent();

            modus = 1;

            suchLabel2.Visible = false;
            sucheBox2.Visible = false;

            thisForm = this;
            mainform2 = form;
            using (var context = new MyCaloriesDbContext())
            {
                selGericht = context.Gerichts.Find(gericht.GerichtId);
            }

            setUp2();
        }

        public void setUp2()
        {

            changeDataSrc();
            rechtsSrc2();

            menuBoard2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuBoard2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            menuBoard2.ReadOnly = true;
            rezeptGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rezeptGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rezeptGrid.ReadOnly = true;

            menuBoard2.Font = new Font("Bahnschrift", 16);
            menuBoard2.DefaultCellStyle.ForeColor = Color.Black;
            rezeptGrid.Font = new Font("Bahnschrift", 16);
            rezeptGrid.DefaultCellStyle.ForeColor = Color.Black;

            suchLabel2.Font = new Font("Bahnschrift", 20);

            menuBoard2.Columns["Tags"].Visible = false;
            menuBoard2.Columns["ZutatId"].Visible = false;
            menuBoard2.Columns["name"].Visible = false;
            menuBoard2.Columns["eiweiß"].Visible = false;
            menuBoard2.Columns["kalorien"].Visible = false;
            menuBoard2.Columns["gewicht"].Visible = false;
            menuBoard2.Columns["GerichtZutats"].Visible = false;
            menuBoard2.Columns["Kategorie"].Visible = false;
            rezeptGrid.Columns["ZutatName"].Visible = false;
            rezeptGrid.Columns["gzId"].Visible = false;
            rezeptGrid.Columns["calories"].Visible = false;
            rezeptGrid.Columns["eiweißes"].Visible = false;
            rezeptGrid.Columns["zutatID"].Visible = false;

            Color color = new Color();
            color = Color.FromArgb(56, 142, 60);

            menuBoard2.GridColor = color;
            menuBoard2.DefaultCellStyle.BackColor = color;
            menuBoard2.ColumnHeadersDefaultCellStyle.BackColor = color;
            menuBoard2.BackgroundColor = color;
            rezeptGrid.GridColor = color;
            rezeptGrid.DefaultCellStyle.BackColor = color;
            rezeptGrid.ColumnHeadersDefaultCellStyle.BackColor = color;
            rezeptGrid.BackgroundColor = color;

            menuBoard2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            menuBoard2.AllowUserToOrderColumns = false;
            menuBoard2.AllowUserToResizeColumns = false;
            menuBoard2.AllowUserToResizeRows = true;
            rezeptGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            rezeptGrid.AllowUserToOrderColumns = false;
            rezeptGrid.AllowUserToResizeColumns = false;
            rezeptGrid.AllowUserToResizeRows = true;
            rezeptGrid.AllowUserToAddRows = false;
            menuBoard2.AllowUserToAddRows = false;

            menuBoard2.AutoGenerateColumns = false;
            rezeptGrid.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn nameColumnMenu = new DataGridViewTextBoxColumn();
            nameColumnMenu.DataPropertyName = "ZutatName";
            nameColumnMenu.Name = "Zutat";
            rezeptGrid.Columns.Add(nameColumnMenu);

            DataGridViewTextBoxColumn mengeColumnMenu = new DataGridViewTextBoxColumn();
            mengeColumnMenu.DataPropertyName = "menge";
            mengeColumnMenu.Name = "Menge";
            rezeptGrid.Columns.Add(mengeColumnMenu);

            DataGridViewTextBoxColumn zutatColumnMenu = new DataGridViewTextBoxColumn();
            zutatColumnMenu.DataPropertyName = "name";
            zutatColumnMenu.Name = "Zutat";
            menuBoard2.Columns.Add(zutatColumnMenu);

            DataGridViewTextBoxColumn calColumnMenu = new DataGridViewTextBoxColumn();
            calColumnMenu.DataPropertyName = "kalorien";
            calColumnMenu.Name = "Kalorien";
            menuBoard2.Columns.Add(calColumnMenu);

            DataGridViewTextBoxColumn eiwColumnMenu = new DataGridViewTextBoxColumn();
            eiwColumnMenu.DataPropertyName = "eiweiß";
            eiwColumnMenu.Name = "Eiweiß";
            menuBoard2.Columns.Add(eiwColumnMenu);

            zutatColumnMenu.Width = 300;
            nameColumnMenu.Width = 200;
        }

        public void setUp()
        {
            changeDataSrc();

            menuBoard2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuBoard2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            menuBoard2.ReadOnly = true;
            rezeptGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rezeptGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rezeptGrid.ReadOnly = true;

            menuBoard2.Font = new Font("Bahnschrift", 16);
            menuBoard2.DefaultCellStyle.ForeColor = Color.Black;
            rezeptGrid.Font = new Font("Bahnschrift", 16);
            rezeptGrid.DefaultCellStyle.ForeColor = Color.Black;

            suchLabel2.Font = new Font("Bahnschrift", 20);

            menuBoard2.Columns["Tags"].Visible = false;
            menuBoard2.Columns["ZutatId"].Visible = false;
            menuBoard2.Columns["name"].Visible = false;
            menuBoard2.Columns["eiweiß"].Visible = false;
            menuBoard2.Columns["kalorien"].Visible = false;
            menuBoard2.Columns["gewicht"].Visible = false;
            menuBoard2.Columns["GerichtZutats"].Visible = false;
            menuBoard2.Columns["Kategorie"].Visible = false;

            Color color = new Color();
            color = Color.FromArgb(56, 142, 60);

            menuBoard2.GridColor = color;
            menuBoard2.DefaultCellStyle.BackColor = color;
            menuBoard2.ColumnHeadersDefaultCellStyle.BackColor = color;
            menuBoard2.BackgroundColor = color;
            rezeptGrid.GridColor = color;
            rezeptGrid.DefaultCellStyle.BackColor = color;
            rezeptGrid.ColumnHeadersDefaultCellStyle.BackColor = color;
            rezeptGrid.BackgroundColor = color;

            menuBoard2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            menuBoard2.AllowUserToOrderColumns = false;
            menuBoard2.AllowUserToResizeColumns = false;
            menuBoard2.AllowUserToResizeRows = true;
            rezeptGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            rezeptGrid.AllowUserToOrderColumns = false;
            rezeptGrid.AllowUserToResizeColumns = false;
            rezeptGrid.AllowUserToResizeRows = true;
            rezeptGrid.AllowUserToAddRows = false;
            menuBoard2.AllowUserToAddRows = false;

            menuBoard2.AutoGenerateColumns = false;
            rezeptGrid.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn nameColumnMenu = new DataGridViewTextBoxColumn();
            nameColumnMenu.DataPropertyName = "name";
            nameColumnMenu.Name = "Zutat";
            rezeptGrid.Columns.Add(nameColumnMenu);

            DataGridViewTextBoxColumn mengeColumnMenu = new DataGridViewTextBoxColumn();
            mengeColumnMenu.DataPropertyName = "menge";
            mengeColumnMenu.Name = "Menge";
            rezeptGrid.Columns.Add(mengeColumnMenu);

            DataGridViewTextBoxColumn zutatColumnMenu = new DataGridViewTextBoxColumn();
            zutatColumnMenu.DataPropertyName = "name";
            zutatColumnMenu.Name = "Zutat";
            menuBoard2.Columns.Add(zutatColumnMenu);

            DataGridViewTextBoxColumn calColumnMenu = new DataGridViewTextBoxColumn();
            calColumnMenu.DataPropertyName = "kalorien";
            calColumnMenu.Name = "Kalorien";
            menuBoard2.Columns.Add(calColumnMenu);

            DataGridViewTextBoxColumn eiwColumnMenu = new DataGridViewTextBoxColumn();
            eiwColumnMenu.DataPropertyName = "eiweiß";
            eiwColumnMenu.Name = "Eiweiß";
            menuBoard2.Columns.Add(eiwColumnMenu);

            zutatColumnMenu.Width = 300;
            nameColumnMenu.Width = 200;
        }

        public void rechtsSrc(int angMenge, float cal, float eiws)
        {
            mengeA = angMenge;
            Anzeige anzeige = new Anzeige
            {
                datum = lueckenFueller,
                name = selectedZutat.name,
                cals = cal,
                eiw = eiws,
                menge = mengeA,
                id = selectedZutat.ZutatId
            };
            bindListRechts.Add(anzeige);

            rezeptGrid.DataSource = bindListRechts;
            this.Invalidate();
        }

        public class MyItem
        {
            public string ZutatName { get; set; }
            public int Menge { get; set; }
            public int gzId { get; set; }
            public float calories { get; set; }
            public float eiweißes { get; set; }
            public int zutatID { get; set; }
        }

        public List<MyItem> zutatenListeOrg;
        BindingList<MyItem> zutatenListe;

        public void rechtsSrc2()
        {
            using (var context = new MyCaloriesDbContext())
            {
                zutatenListeOrg = context.GerichtZutats
                .Where(gz => gz.GerichtId == selGericht.GerichtId)
                .Select(gz => new MyItem
                {
                    ZutatName = gz.Zutat.name,
                    Menge = gz.menge,
                    gzId = gz.GerichtZutatId,
                    zutatID = gz.ZutatId,
                    calories = 0,
                    eiweißes = 0
                }).ToList();
                
                //calories = rechtsSrc2helpCal(gz.ZutatId, gz.menge),
                //eiweißes = rechtsSrc2helpEiw(gz.ZutatId, gz.menge)
            }
            zutatenListe = new BindingList<MyItem>(zutatenListeOrg);
            foreach (var elem in zutatenListe)
            {
                if (elem.calories <= 0)
                {
                    using (var context = new MyCaloriesDbContext())
                    {
                        GerichtZutat gz = context.GerichtZutats.Find(elem.gzId);
                        elem.calories = rechtsSrc2helpCal(gz.ZutatId, gz.menge);
                        elem.eiweißes = rechtsSrc2helpEiw(gz.ZutatId, gz.menge);
                    }
                }
            }

            rezeptGrid.DataSource = zutatenListe;
            this.Invalidate();
        }
        public void rechtsSrc2(int meng, float cls, float ews)
        {
            using (var context = new MyCaloriesDbContext())
            {
                selectedZutat = context.Zutaten.Find(selectedZutat.ZutatId);
            }
            MyItem item = new MyItem
            {
                ZutatName = selectedZutat.name,
                Menge = meng,
                gzId = -1,
                zutatID = selectedZutat.ZutatId,
                calories = cls,
                eiweißes = ews
            };
            zutatenListe.Add(item);
            rezeptGrid.DataSource = zutatenListe;
            this.Invalidate();
        }

        public float rechtsSrc2helpCal(int id, int meng)
        {
            using (var context = new MyCaloriesDbContext())
            {
                Zutat zutat = context.Zutaten.Find(id);
                float calPro1 = (float)(zutat.kalorien / zutat.gewicht);
                return calPro1 * meng;

            }
        }
        public float rechtsSrc2helpEiw(int id, int meng)
        {
            using (var context = new MyCaloriesDbContext())
            {
                Zutat zutat = context.Zutaten.Find(id);
                float eiwPro1 = (float)(zutat.eiweiß / zutat.gewicht);
                return eiwPro1 * meng;
            }
        }



        /*
        var items = from z in Zutaten
            select new MyItem
            {
                Name = z.Name,
                Kalorien = z.Kalorien
            };

        dataGridView.DataSource = items.ToList();

         */

        public void changeDataSrc()
        {
            using (var context = new MyCaloriesDbContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                zutListe = context.Zutaten.ToList();
                bindList = new BindingList<Zutat>(zutListe);
                menuBoard2.DataSource = bindList;
            }
            this.Invalidate();
        }

        private void closeBtn5_Click(object sender, EventArgs e)
        {
            if (modus == 0)
            {
                mainform.Activate();
                Dispose();
            }
            else if (modus == 1)
            {
                mainform2.Activate();
                Dispose();
            }
        }

        private void sucheBox2_TextChanged(object sender, EventArgs e)
        {
            string eingabe = sucheBox2.Text.ToLower();

            if (string.IsNullOrEmpty(eingabe))
            {
                this.changeDataSrc();
            }
            else
            {
                var query = zutListe.Where(z => z.name.ToLower().Contains(eingabe)).ToList();

                menuBoard2.DataSource = query;
                this.Invalidate();
            }
        }

        public int mengeBearb = 0;
        List<GerichtZutat> gerZuts;
        Gericht bearbGericht;

        private void saveChanges6_Click(object sender, EventArgs e)
        {
            if (modus == 0)
            {
                float meng = 0;
                float kals = 0;
                float eiws = 0;

                foreach (Anzeige element in bindListRechts)
                {
                    meng = meng + element.menge;
                    kals = kals + element.cals;
                    eiws = eiws + element.eiw;
                }
                Form7 form = new Form7(this, kals, eiws, meng);
                form.ShowDialog();
            }
            else if (modus == 1)
            {
                int mengeFa = 0;
                foreach (var elem in zutatenListe)
                {
                    mengeFa = mengeFa + elem.Menge;
                }
                Form11 form = new Form11(this, mengeFa);
                form.ShowDialog();
                if (mengeBearb == 0)
                {
                    return;
                }
                
                int gerId;
                int zutId;
                float sumCals = 0;
                float sumEiws = 0;

                using (var context = new MyCaloriesDbContext())
                {
                    gerId = context.Gerichts.Find(selGericht.GerichtId).GerichtId;
                    gerZuts = context.GerichtZutats.Where(gz => gz.GerichtId == gerId).ToList();
                }
                
                foreach (var elem in zutatenListe)
                {
                    sumCals = sumCals + elem.calories;
                    sumEiws = sumEiws + elem.eiweißes;

                    if (elem.gzId < 0)
                    {
                        using (var context = new MyCaloriesDbContext())
                        {
                            zutId = context.Zutaten.Find(elem.zutatID).ZutatId;
                            GerichtZutat gerichZutat = new GerichtZutat
                            {
                                GerichtId = gerId,
                                ZutatId = zutId,
                                menge = elem.Menge,
                            };
                            gerZuts.Add(gerichZutat);
                            context.GerichtZutats.Add(gerichZutat);
                            context.SaveChanges();
                        }
                    }
                }

                using (var context = new MyCaloriesDbContext())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    bearbGericht = context.Gerichts.Find(gerId);
                    bearbGericht.GerichtZutats = gersZuts;
                    bearbGericht.kal = sumCals;
                    bearbGericht.eiw = sumEiws;
                    bearbGericht.menge = mengeBearb;
                    context.Entry(bearbGericht).State = System.Data.Entity.EntityState.Modified;

                    mainform2.setUp2DataGrid2(sumCals, mengeBearb,sumEiws);
                    context.SaveChanges();

                    zutatenListe.Clear();
                }
            }
            Dispose();
            if (mainform2 != null)
            {
                mainform2.Activate(); //Fehler
            }
            this.Invalidate();
        }

        public void makeGericht(string nameFuerGericht, float kalorienFuerGericht, float eiweißFuerGericht, float mengeFuerGericht, Zutat.Kategorie kat)
        {
            using (var context = new MyCaloriesDbContext())
            {
                listFuerGerichtZutaten.Clear(); listFuerGerichtMengen.Clear();
                List<GerichtZutat> listFuerGericht = new List<GerichtZutat>();
                foreach (var element in bindListRechts)
                {
                    //int cntr = 0;
                    //listFuerGerichtZutaten.Add(context.Zutaten.Find(element.id));
                    //listFuerGerichtMengen.Add(element.menge);
                    GerichtZutat gerichtZutat = new GerichtZutat
                    {
                        Zutat = context.Zutaten.Find(element.id),
                        menge = element.menge,
                    };
                    listFuerGericht.Add(gerichtZutat);
                }
                Gericht gericht = new Gericht
                {
                    name = nameFuerGericht,
                    kal = kalorienFuerGericht,
                    eiw = eiweißFuerGericht,
                    menge = mengeFuerGericht,
                    GerichtZutats = listFuerGericht
                };
                int eiwFuerZutat = (int)Math.Round(eiweißFuerGericht);
                int kalFuerZutat = (int)Math.Round(kalorienFuerGericht);
                int mengFuerZutat  = (int)Math.Round(mengeFuerGericht);
                
                Zutat zutat = new Zutat
                {
                    name = nameFuerGericht,
                    eiweiß = eiwFuerZutat,
                    kalorien = kalFuerZutat,
                    gewicht = mengFuerZutat,
                    kategorie = kat
                };
                context.Gerichts.Add(gericht);
                context.Zutaten.Add(zutat);
                context.SaveChanges();
            }
            mainform.changeDataSrc();
            mainform.Activate();
            this.Dispose();
        }

        private void menuBoard2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedZutat = (Zutat)menuBoard2.Rows[e.RowIndex].DataBoundItem;
            //(Form6)this.FindForm()
            if (modus != 1)
            {
                form4 = new Form4(thisForm, 1, selectedZutat);
            }
            else if (modus == 1)
            {
                form4 = new Form4(thisForm, 2, selectedZutat);
            }
            form4.welcheZutatBox.Text = selectedZutat.name;
            form4.ShowDialog();
        }

        private void rezeptGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (modus == 0)
            {
                Anzeige selectedAn = (Anzeige)rezeptGrid.Rows[e.RowIndex].DataBoundItem;
                bindListRechts.Remove(selectedAn);
                rezeptGrid.Invalidate();
            }
            else if (modus == 1)
            {
                Form10 form = new Form10(this);
                form.ShowDialog();

                if (loeschenConfirmed)
                {
                    var selectedItem = (MyItem)rezeptGrid.Rows[e.RowIndex].DataBoundItem;
                    using (var context = new MyCaloriesDbContext())
                    {
                        var selGerZut = context.GerichtZutats.FirstOrDefault(gz => gz.GerichtZutatId == selectedItem.gzId);
                        if (selGerZut == null)
                        {
                            zutatenListe.Remove(selectedItem);
                        }
                        else
                        {
                            context.GerichtZutats.Remove(selGerZut);
                        }

                        context.SaveChanges();
                    }
                    Invalidate();
                }
            }
        }

        
    }
}
