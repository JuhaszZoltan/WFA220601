using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220601
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        public FrmMain()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.heart;
        }

        private void BtnKoszonj_Click(object sender, EventArgs e)
        {
            if (lblSzoveg.Text == "###")
                lblSzoveg.Text = "Szia Zoli!";
            else
            {
                lblSzoveg.Text = 
                    "Már köszöntem...\n" +
                    "De kattintgass nyugodtan!";

                Color ujSzin = Color.FromArgb(
                    red: rnd.Next(256),
                    green: rnd.Next(256),
                    blue: rnd.Next(256));

                this.BackColor = ujSzin;
                btnKoszonj.ForeColor = ujSzin;
                lblSzoveg.ForeColor = ujSzin;
            }
        }
    }
}
