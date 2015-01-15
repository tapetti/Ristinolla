using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading; //threadin takia lisätty

namespace ristinolla
{
    public partial class Form2 : Form
    {
        Thread th; //mahdollistaa että toinen ikkuna sulkeutuu
        bool vuoro = true; //tämän perusteella joko X tai O
        int laskuri = 0; //käytetään laskee pelin loppumiseen

        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            lopeta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (A2.Text == "")
            {
                if (vuoro)
                {
                    A2.Text = "X";
                }
                else
                {
                    A2.Text = "O";
                }
                vuoro = !vuoro;
                laskuri++;
                tarkistus();
                tila();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (A1.Text == "")
            {
                if (vuoro)
                {
                    A1.Text = "X";
                }
                else
                {
                    A1.Text = "O";
                }
                vuoro = !vuoro;
                laskuri++;
                tarkistus();
                tila();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (B2.Text == "")
            {
                if (vuoro)
                {
                    B2.Text = "X";
                }
                else
                {
                    B2.Text = "O";
                }
                vuoro = !vuoro;
                laskuri++;
                tarkistus();
                tila();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (A3.Text == "")
            {
                if (vuoro)
                {
                    A3.Text = "X";
                }
                else
                {
                    A3.Text = "O";
                }
                vuoro = !vuoro;
                laskuri++;
                tarkistus();
                tila();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (B3.Text == "")
            {
                if (vuoro)
                {
                    B3.Text = "X";
                }
                else
                {
                    B3.Text = "O";
                }
                vuoro = !vuoro;
                laskuri++;
                tarkistus();
                tila();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (C3.Text == "")
            {
                if (vuoro)
                {
                    C3.Text = "X";
                }
                else
                {
                    C3.Text = "O";
                }
                vuoro = !vuoro;
                laskuri++;
                tarkistus();
                tila();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (B1.Text == "")
            {
                if (vuoro)
                {
                    B1.Text = "X";
                }
                else
                {
                    B1.Text = "O";
                }
                vuoro = !vuoro;
                laskuri++;
                tarkistus();
                tila();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (C1.Text == "")
            {
                if (vuoro)
                {
                    C1.Text = "X";
                }
                else
                {
                    C1.Text = "O";
                }
                vuoro = !vuoro;
                laskuri++;
                tarkistus();
                tila();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (C2.Text == "")
            {
                if (vuoro)
                {
                    C2.Text = "X";
                }
                else
                {
                    C2.Text = "O";
                }
                vuoro = !vuoro;
                laskuri++;
                tarkistus();
                tila();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void tarkistus()
        {
            bool voitto = false;

            //vaaka
            if (A1.Text != "" && A1.Text == A2.Text && A1.Text == A3.Text)
            {
                voitto = true;
            }
            if (B1.Text != "" && B1.Text == B2.Text && B1.Text == B3.Text)
            {
                voitto = true;
            }
            if (C1.Text != "" && C1.Text == C2.Text && C1.Text == C3.Text)
            {
                voitto = true;
            }
            //pysty
            if (A1.Text != "" && A1.Text == B1.Text && A1.Text == C1.Text)
            {
                voitto = true;
            }
            if (A2.Text != "" && A2.Text == B2.Text && A2.Text == C2.Text)
            {
                voitto = true;
            }
            if (A3.Text != "" && A3.Text == B3.Text && A3.Text == C3.Text)
            {
                voitto = true;
            }
            //vinosti
            if (A1.Text != "" && A1.Text == B2.Text && A1.Text == C3.Text)
            {
                voitto = true;
            }
            if (A3.Text != "" && A3.Text == B2.Text && A3.Text == C1.Text)
            {
                voitto = true;
            }

            if(laskuri == 9 || voitto){

                if (voitto)
                {
                    String voittaja = "";
                    if (vuoro)
                    {
                        voittaja = "O";
                    }
                    else
                    {
                        voittaja = "X";
                    }
                    if(MessageBox.Show(voittaja + " Voitti pelin!\n\nHaluatko aloittaa uuden pelin?","Peli päättyi",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                        aloitaUusi();
                    }
                    else
                    {
                        lopeta();
                    }
                }
                else
                {
                    if (MessageBox.Show("Tasapeli!\n\nHaluatko aloittaa uuden pelin?", "Peli päättyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        aloitaUusi();
                    }
                    else
                    {
                        lopeta();
                    }
                }
            }

        }

        private void aloitaUusi()
        {
            laskuri = 0;
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";

        }
        private void lopeta()
        {
            this.Close();
            th = new Thread(form1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void tila()
        {
            if (vuoro)
            {
                kenen.Text = "X:n vuoro";
            }
            else
            {
                kenen.Text = "O:n vuoro";
            }
        }

        private void form1()
        {
            Application.Run(new Form1());
        }
    }
}
