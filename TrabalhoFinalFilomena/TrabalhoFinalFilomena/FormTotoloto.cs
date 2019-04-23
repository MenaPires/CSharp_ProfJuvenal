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
using TrabalhoFinalFilomena.Properties;

namespace TrabalhoFinalFilomena
{
    public partial class FormTotoloto : Form
    {
        public FormTotoloto()
        {
            InitializeComponent();
        }

        ArrayList arr_totoloto = new ArrayList();

        private string mensagemNao = "Não existem apostas vencedoras";

        private void btn_validarTotoloto_Click(object sender, EventArgs e)
        {
            int n1 = (int)nud_n1t.Value;
            int n2 = (int)nud_n2t.Value;
            int n3 = (int)nud_n3t.Value;
            int n4 = (int)nud_n4t.Value;
            int n5 = (int)nud_n5t.Value;
            int ns = (int)nud_nst.Value;
            string dia = cmb_diasToto.SelectedItem.ToString();

            Totoloto obj_toto = new Totoloto(
                new DateTime(),
                new DateTime(),
                2.5,
                1000000,
                n1,
                n2,
                n3,
                n4,
                n5,
                ns
             );

            arr_totoloto.Add(obj_toto);

            lst_totoloto.DataSource = null;
            lst_totoloto.DataSource = arr_totoloto;
            lst_totoloto.DisplayMember = "ChaveCompleta";
            reset();
        }
        private void reset()
        {
            nud_n1t.Value = 0;
            nud_n2t.Value = 0;
            nud_n3t.Value = 0;
            nud_n4t.Value = 0;
            nud_n5t.Value = 0;
            nud_nst.Value = 0;
            cmb_diasToto.SelectedItem = null;
        }

        private void btn_voltarT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 home = new Form1();
            home.Show();
        }

        private void btn_comparar_Click(object sender, EventArgs e)
        {
            int n1 = (int)nud_n1t.Value;
            int n2 = (int)nud_n2t.Value;
            int n3 = (int)nud_n3t.Value;
            int n4 = (int)nud_n4t.Value;
            int n5 = (int)nud_n5t.Value;
            int ns = (int)nud_nst.Value;

            foreach (Totoloto temp in arr_totoloto)
            {
                if (temp.vencedor(n1, n2, n3, n4, n5, ns))
                {
                    MessageBox.Show(temp.ChaveCompleta + "\nAposta Vencedora");
                    return;
                }
                
            }

            MessageBox.Show(this.mensagemNao);
        }
    }
}
