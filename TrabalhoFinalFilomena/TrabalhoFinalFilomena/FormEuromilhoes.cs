using System;
using System.Collections;
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
    public partial class FormEuromilhoes : Form
    {
        public FormEuromilhoes()
        {
            InitializeComponent();
        }

        ArrayList arr_euromilhoes = new ArrayList();

        private string mensagemNao = "Não existem apostas vencedoras";

        private void btn_voltarE_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 home = new Form1();
            home.Show();
        }
        private void btn_validarAposta_Click(object sender, EventArgs e)
        {
            int n1 = (int)nud_n1e.Value;
            int n2 = (int)nud_n2e.Value;
            int n3 = (int)nud_n3e.Value;
            int n4 = (int)nud_n4e.Value;
            int n5 = (int)nud_n5e.Value;
            int e1 = (int)nud_e1e.Value;
            int e2 = (int)nud_e2e.Value;
            string dia = cmb_diasEuro.SelectedItem.ToString();

            Euromilhoes obj_euro = new Euromilhoes(
                new DateTime(),
                new DateTime(),
                2.0,
                1000000,
                n1, n2, n3, n4, n5, e1, e2);
                

            arr_euromilhoes.Add(obj_euro);

            lst_euromilhoes.DataSource = null;
            lst_euromilhoes.DataSource = arr_euromilhoes;
            lst_euromilhoes.DisplayMember = "ChaveCompleta";
            reset();
        }

        private void reset ()
        {
            nud_n1e.Value = 0;
            nud_n2e.Value = 0;
            nud_n3e.Value = 0;
            nud_n4e.Value = 0;
            nud_n5e.Value = 0;
            nud_e1e.Value = 0;
            nud_e2e.Value = 0;
            cmb_diasEuro.SelectedItem = null;
        }

        private void btn_comparar_Click(object sender, EventArgs e)
        {
            int n1 = (int)nud_n1e.Value;
            int n2 = (int)nud_n2e.Value;
            int n3 = (int)nud_n3e.Value;
            int n4 = (int)nud_n4e.Value;
            int n5 = (int)nud_n5e.Value;
            int e1 = (int)nud_e1e.Value;
            int e2 = (int)nud_e2e.Value;

            foreach (Euromilhoes temp in arr_euromilhoes)
            {
                if (temp.vencedor(n1, n2, n3, n4, n5, e1, e2))
                {
                    MessageBox.Show(temp.ChaveCompleta + "\nAposta Vencedora");
                    return;
                }
            }

            MessageBox.Show(this.mensagemNao);
        }
    }
}
