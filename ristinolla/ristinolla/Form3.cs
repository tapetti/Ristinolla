using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ristinolla
{
    public partial class Form3 : Form
    {
        Thread th;
        bool vuoro = true;
        int laskuri = 0;
        int ypiste = 0;
        int xpiste = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Poistu_Click(object sender, EventArgs e)
        {
            lopeta();
        }

        private void klikkaus(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "")
            {
                if (vuoro)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
                laskuri++;
                tarkistus();
                vuoro = !vuoro;
                if (vuoro)
                {
                    kenenVuoro.Text = "X:n vuoro";
                }
                else
                {
                    kenenVuoro.Text = "O:n vuoro";
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Ruudussa on jo merkki!\nValitse jokin toinen ruutu.", "Virhe!");
            }
        }

        private void tarkistus()
        {
            bool voitto = false;

            //Tarkastus
            //Vaaka
            
            if(A3.Text != "" && A3.Text == A5.Text && A3.Text == A2.Text && A3.Text == A4.Text){
                voitto = true;
            }
            if (B3.Text != "" && B3.Text == B5.Text && B3.Text == B2.Text && B3.Text == B4.Text)
            {
                voitto = true;
            }
            if (C3.Text != "" && C3.Text == C5.Text && C3.Text == C2.Text && C3.Text == C4.Text)
            {
                voitto = true;
            }
            if (D3.Text != "" && D3.Text == D5.Text && D3.Text == D2.Text && D3.Text == D4.Text)
            {
                voitto = true;
            }
            if (F3.Text != "" && F3.Text == F5.Text && F3.Text == F2.Text && F3.Text == F4.Text)//Melkein osasin aakkoset :D
            {
                voitto = true;
            }
            //jostain syystä OR ei toiminut niin pitää erikseen laitta ääriruudut
            if (A3.Text != "" && A3.Text == A1.Text && A3.Text == A2.Text && A3.Text == A4.Text)
            {
                voitto = true;
            }
            if (B3.Text != "" && B3.Text == B1.Text && B3.Text == B2.Text && B3.Text == B4.Text)
            {
                voitto = true;
            }
            if (C3.Text != "" && C3.Text == C1.Text && C3.Text == C2.Text && C3.Text == C4.Text)
            {
                voitto = true;
            }
            if (D3.Text != "" && D3.Text == D1.Text && D3.Text == D2.Text && D3.Text == D4.Text)
            {
                voitto = true;
            }
            if (F3.Text != "" && F3.Text == F1.Text && F3.Text == F2.Text && F3.Text == F4.Text)//Melkein osasin aakkoset :D
            {
                voitto = true;
            }
            
            
            //pysty
            
            if (C1.Text != "" && C1.Text == A1.Text && C1.Text == B1.Text && C1.Text == D1.Text)
            {
                voitto = true;
            }
            if (C2.Text != "" && C2.Text == A2.Text && C2.Text == B2.Text && C2.Text == D2.Text)
            {
                voitto = true;
            }
            if (C3.Text != "" && C3.Text == A3.Text && C3.Text == B3.Text && C3.Text == D3.Text)
            {
                voitto = true;
            }
            if (C4.Text != "" && C4.Text == A4.Text && C4.Text == B4.Text && C4.Text == D4.Text)
            {
                voitto = true;
            }
            if (C5.Text != "" && C5.Text == A5.Text && C5.Text == B5.Text && C5.Text == D5.Text)
            {
                voitto = true;
            }
            //jostain syystä OR ei toiminut niin pitää erikseen laitta ääriruudut
            if (C1.Text != "" && C1.Text == F1.Text && C1.Text == B1.Text && C1.Text == D1.Text)
            {
                voitto = true;
            }
            if (C2.Text != "" && C2.Text == F2.Text && C2.Text == B2.Text && C2.Text == D2.Text)
            {
                voitto = true;
            }
            if (C3.Text != "" && C3.Text == F3.Text && C3.Text == B3.Text && C3.Text == D3.Text)
            {
                voitto = true;
            }
            if (C4.Text != "" && C4.Text == F4.Text && C4.Text == B4.Text && C4.Text == D4.Text)
            {
                voitto = true;
            }
            if (C5.Text != "" && C5.Text == F5.Text && C5.Text == B5.Text && C5.Text == D5.Text)
            {
                voitto = true;
            }
            
            //vinosti
            if (A2.Text != "" && A2.Text == B3.Text && A2.Text == C4.Text && A2.Text == D5.Text)
            {
                voitto = true;
            }
            if (B1.Text != "" && B1.Text == C2.Text && B1.Text == D3.Text && B1.Text == F4.Text)
            {
                voitto = true;
            }
            if (C3.Text != "" && C3.Text == A1.Text && C3.Text == B2.Text && C3.Text == D4.Text)
            {
                voitto = true;
            }
            if (C3.Text != "" && C3.Text == F5.Text && C3.Text == B2.Text && C3.Text == D4.Text)
            {
                voitto = true;
            }
            //toiseen suuntaan vinosti
            if (C3.Text != "" && C3.Text == A5.Text && C3.Text == B4.Text && C3.Text == D2.Text)
            {
                voitto = true;
            }
            if (C3.Text != "" && C3.Text == F1.Text && C3.Text == B4.Text && C3.Text == D2.Text)
            {
                voitto = true;
            }
            if (A4.Text != "" && A4.Text == B3.Text && A4.Text == C2.Text && A4.Text == D1.Text)
            {
                voitto = true;
            }
            if (B5.Text != "" && B5.Text == C4.Text && B5.Text == D3.Text && B5.Text == F2.Text)
            {
                voitto = true;
            }

            


            if (voitto)
            {
                String voittaja = "";

                if (vuoro)
                {
                    voittaja = "X";
                    xpiste++;
                    pojot();
                }
                else
                {
                    voittaja = "O";
                    ypiste++;
                    pojot();
                }
                if(MessageBox.Show(voittaja + " Voitti pelin!\n\nHaluatko aloittaa uuden pelin?","Peli päättyi",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    //kaikkien tyhjentäminen
                    //foreach crashaa koko ohjelman joten pitkänkaavan ratkaisulla homma korjattu
                    /*foreach (Control c in Controls){
                    Button b = (Button)c;
                    b.Text = "";
                    }*/
                    A1.Text = ""; A2.Text = ""; A3.Text = ""; A4.Text = ""; A5.Text = "";
                    B1.Text = ""; B2.Text = ""; B3.Text = ""; B4.Text = ""; B5.Text = "";
                    C1.Text = ""; C2.Text = ""; C3.Text = ""; C4.Text = ""; C5.Text = "";
                    D1.Text = ""; D2.Text = ""; D3.Text = ""; D4.Text = ""; D5.Text = "";
                    F1.Text = ""; F2.Text = ""; F3.Text = ""; F4.Text = ""; F5.Text = "";
                    laskuri = 0;
                    Poistu.Text = "Poistu";
                }
                else
                {
                    lopeta();
                } 
            }
            if (laskuri == 25)
            {
                if (MessageBox.Show("Tasapeli!\n\nHaluatko aloittaa uuden pelin?", "Peli päättyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //kaikkien tyhjentäminen
                    //foreach crashaa koko ohjelman joten pitkänkaavan ratkaisulla homma korjattu
                    /*foreach (Control c in Controls){
                    Button b = (Button)c;
                    b.Text = "";
                    }*/
                    A1.Text = ""; A2.Text = ""; A3.Text = ""; A4.Text = ""; A5.Text = "";
                    B1.Text = ""; B2.Text = ""; B3.Text = ""; B4.Text = ""; B5.Text = "";
                    C1.Text = ""; C2.Text = ""; C3.Text = ""; C4.Text = ""; C5.Text = "";
                    D1.Text = ""; D2.Text = ""; D3.Text = ""; D4.Text = ""; D5.Text = "";
                    F1.Text = ""; F2.Text = ""; F3.Text = ""; F4.Text = ""; F5.Text = "";
                    laskuri = 0;
                    Poistu.Text = "Poistu";
                }
            }
            
        }

        private void lopeta()
        {
            this.Close();
            th = new Thread(form1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void form1()
        {
            Application.Run(new Form1());
        }

        private void pojot()
        {
            Ypisteet.Text = ""+ypiste;
            Xpisteet.Text = ""+xpiste;
        }

        private void nollaa_Click(object sender, EventArgs e)
        {
            xpiste = 0;
            ypiste = 0;
            pojot();
        }
    }
}
