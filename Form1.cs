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
    public partial class Form1 : Form
    {
        Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(form3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ohje_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("3x3\n\nYritä saada 3 ristiä tai 3 nollaa peräkkäin, joko pysty suoraan tai vaaaka suoraan tai vinosti\n\n\n5x5\n\nYritä saada 4 ristiä tai 4 nollaa peräkkäin, joko pysty suoraan tai vaaaka suoraan tai vinosti\n\n-Tape","Ohje");

        }

        private void Aloita3x3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(form2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void form2()
        {
            Application.Run(new Form2());
        }

        private void form3()
        {
            Application.Run(new Form3());
        }
    }
}
