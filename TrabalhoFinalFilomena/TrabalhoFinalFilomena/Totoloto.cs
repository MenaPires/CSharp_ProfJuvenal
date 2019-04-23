using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinalFilomena.Properties;
using System.Collections;
using System.IO;
using JogoSantaCasa;

namespace TrabalhoFinalFilomena.Properties
{
    class Totoloto:JogosSantaCasa
    {
        private int[] chave = new int[5];
        private int m_int_ns;

        public Totoloto(
            DateTime DataAposta, 
            DateTime DataSorteio, 
            double ValorAposta, 
            double ValorPremio, 
            int N1, 
            int N2,
            int N3,
            int N4,
            int N5, 
            int NS
         )
        {
            this.m_str_nomeJogo = "Totoloto";
            this.m_dtm_dataAposta = DataAposta;
            this.m_dtm_dataSorteio = DataSorteio;
            this.m_dbl_valorAposta = ValorAposta;
            this.m_dbl_valorPremio = ValorPremio;
            this.chave[0] = N1;
            this.chave[1] = N2;
            this.chave[2] = N3;
            this.chave[3] = N4;
            this.chave[4] = N5;
            this.m_int_ns = NS;
            this.m_str_chaveCompleta = N1 + " " + N2 + " " + N3 + " " + N4 + " " + N5 + " + " + NS;

        }
        public int N1 { get { return chave[0]; } }
        public int N2 { get { return chave[1]; } }
        public int N3 { get { return chave[2]; } }
        public int N4 { get { return chave[3]; } }
        public int N5 { get { return chave[4]; } }
        public int NS { get { return m_int_ns; } } 
        
        public Boolean vencedor (int N1, int N2, int N3, int N4, int N5, int NS)
        {
            if (
                chave.Contains(N1) &&
                chave.Contains(N2) &&
                chave.Contains(N3) &&
                chave.Contains(N4) &&
                chave.Contains(N5) &&
                m_int_ns == NS
            )
            {
                return true;
            }
            return false;
        }
    }
}
