using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinalFilomena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_euromilhoes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEuromilhoes euro = new FormEuromilhoes();
            euro.Show();
        }

        private void btn_totoloto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormTotoloto toto = new FormTotoloto();
            toto.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}