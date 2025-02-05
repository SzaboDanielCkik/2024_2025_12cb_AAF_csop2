using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_01_31_FormAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void szinezesBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decimal osszeg = szam1NUD.Value + szam2NUD.Value;
            //int osszeg = (int)(szam1NUD.Value + szam2NUD.Value);
            double eredmeny = 0;
           
            EredmenyLabel.Text = "" + osszeg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MuveletCombo.Text = ""+MuveletCombo.Items[0];
        }

        private void EredmenyLabel_Click(object sender, EventArgs e)
        {

        }

        private void szam2NUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void szam1NUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MuveletCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
