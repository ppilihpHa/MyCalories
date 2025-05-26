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
    public partial class Form4 : Form
    {
        public Form1 mainForm;
        public Form6 mainForm2;
        public Zutat mahlzeitZutat;
        public int mahlzeitMenge;
        public float calMahlzeitPro1g;
        public float eiwMahlzeitPro1g;

        DateTime zeitpunkt;
        DateTime anzeigeDatum;

        public float calMahlzeit;
        public float eiwMahlzeit;
        public int modus; // 0 kommt von main ; 1 kommt von 6; 2 kommt von 6 zum bearbeiten

        string format = "dd.mm";

        public Form4(Form1 form, int mode)
        {
            InitializeComponent();
            mainForm = form;
            modus = mode;
            anzeigeDatum = DateTime.Now;
            string heuteDate = anzeigeDatum.ToString("dd.MM.HH:mm");
            wannBox.Text = heuteDate;
        }

        public void setDatum()
        {
            wannBox.Text = anzeigeDatum.ToString("dd.MM.HH:mm");
        }
        public Form4(Form6 form, int mode, Zutat zutat)
        {
            InitializeComponent();
            mainForm2 = form;
            modus = mode;
            mahlzeitZutat = zutat;
            if (modus == 1 || modus == 2)
            {
                wannBox.Visible = false;
                wannLabel.Visible = false;
                addTag.Visible = false;
                subTag.Visible = false;
            }
        }


        private void addMahlBttn_Click(object sender, EventArgs e)
        {
            if (modus == 0)
            {
                foreach (Zutat element in mainForm.zutatenListe)
                {
                    if (welcheZutatBox.Text.Equals(element.name))
                    {
                        mahlzeitZutat = element;
                    }
                }
                if (mahlzeitZutat == null)
                {
                    MessageBox.Show("bitte eine gültige Zutat angeben");
                    return;
                }
                int menge;
                if (int.TryParse(wieVielBox.Text, out menge))
                {
                    mahlzeitMenge = menge;
                }
                else
                {
                    MessageBox.Show("bitte eine Zahl als Gewicht angeben");
                    return;
                }
                calMahlzeitPro1g = (float)mahlzeitZutat.kalorien / mahlzeitZutat.gewicht;
                eiwMahlzeitPro1g = (float)mahlzeitZutat.eiweiß / mahlzeitZutat.gewicht;

                calMahlzeit = calMahlzeitPro1g * mahlzeitMenge;
                eiwMahlzeit = eiwMahlzeitPro1g * mahlzeitMenge;

                string eingabe = wannBox.Text;
                string datum = eingabe + "." + DateTime.Now.Year.ToString();
                if (DateTime.TryParseExact(datum, "dd.MM.HH:mm.yyyy", null, System.Globalization.DateTimeStyles.None, out zeitpunkt))
                {


                    mainForm.rechnen(calMahlzeit, eiwMahlzeit, mahlzeitMenge, zeitpunkt);
                }
                else
                {
                    MessageBox.Show("bitte ein gültiges Datum angeben");
                    return;
                }

                mainForm.Activate();
                this.Dispose();
            }
            else if (modus == 1)
            {
                int menge;
                if (int.TryParse(wieVielBox.Text, out menge))
                {
                    mahlzeitMenge = menge;
                }
                else
                {
                    MessageBox.Show("bitte eine Zahl als Gewicht angeben");
                    return;
                }

                calMahlzeitPro1g = (float)mahlzeitZutat.kalorien / mahlzeitZutat.gewicht;
                eiwMahlzeitPro1g = (float)mahlzeitZutat.eiweiß / mahlzeitZutat.gewicht;

                calMahlzeit = calMahlzeitPro1g * mahlzeitMenge;
                eiwMahlzeit = eiwMahlzeitPro1g * mahlzeitMenge;

                mainForm2.rechtsSrc(mahlzeitMenge, calMahlzeit, eiwMahlzeit);
                mainForm2.Activate();
                this.Dispose();
            }
            else if (modus == 2)
            {
                int menge;
                if (int.TryParse(wieVielBox.Text, out menge))
                {
                    mahlzeitMenge = menge;
                }
                else
                {
                    MessageBox.Show("bitte eine Zahl als Gewicht angeben");
                    return;
                }

                calMahlzeitPro1g = (float)mahlzeitZutat.kalorien / mahlzeitZutat.gewicht;
                eiwMahlzeitPro1g = (float)mahlzeitZutat.eiweiß / mahlzeitZutat.gewicht;

                calMahlzeit = calMahlzeitPro1g * mahlzeitMenge;
                eiwMahlzeit = eiwMahlzeitPro1g * mahlzeitMenge;

                mainForm2.rechtsSrc2(mahlzeitMenge, calMahlzeit, eiwMahlzeit);
                mainForm2.Activate();
                this.Dispose();
            }
        }

        private void addTag_Click(object sender, EventArgs e)
        {
            anzeigeDatum = anzeigeDatum.AddDays(1);
            setDatum();
            Invalidate();
        }

        private void subTag_Click(object sender, EventArgs e)
        {
            anzeigeDatum = anzeigeDatum.AddDays(-1);
            setDatum();
            Invalidate();
        }

        private void wieVielBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                addMahlBttn.PerformClick();
            }
        }

        private void addTag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                addMahlBttn.PerformClick();
            }
        }

        private void subTag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                addMahlBttn.PerformClick();
            }
        }

        private void welcheZutatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                addMahlBttn.PerformClick();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            if (modus == 1)
            {
                mainForm2.Activate();
            }
            else if (modus == 0)
            {
                mainForm.hinzuAbbgebrochen = true;
                mainForm.Activate();
            }
            else if (modus == 2)
            {
                mainForm2.Activate();
            }
            this.Dispose();
        }

    }
}
