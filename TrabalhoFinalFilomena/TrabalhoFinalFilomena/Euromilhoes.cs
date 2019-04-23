using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoSantaCasa;
using System.Collections;
using System.IO;

namespace TrabalhoFinalFilomena
{
    class Euromilhoes:JogosSantaCasa
    {
        private int[] numeros = new int[5];
        private int[] estrelas = new int[2];

        public int N1 { get { return numeros[0]; } }
        public int N2 { get { return numeros[1]; } }
        public int N3 { get { return numeros[2]; } }
        public int N4 { get { return numeros[3]; } }
        public int N5 { get { return numeros[4]; } }
        public int E1 { get { return estrelas[0]; } }
        public int E2 { get { return estrelas[1]; } }

        public Euromilhoes(
            DateTime DataAposta,
            DateTime DataSorteio,
            double ValorAposta,
            double ValorPremio,
            int N1, 
            int N2, 
            int N3, 
            int N4, 
            int N5, 
            int E1, 
            int E2
        )
        {
            this.m_str_nomeJogo = "Euromilhões";
            this.m_dtm_dataAposta = DataAposta;
            this.m_dtm_dataSorteio = DataSorteio;
            this.m_dbl_valorAposta = ValorAposta;
            this.m_dbl_valorPremio = ValorPremio;
            this.numeros[0] = N1;
            this.numeros[1] = N2;
            this.numeros[2] = N3;
            this.numeros[3] = N4;
            this.numeros[4] = N5;
            this.estrelas[0] = E1;
            this.estrelas[1] = E2;
            this.m_str_chaveCompleta = N1 + " " + N2 + " " + N3 + " " + N4 + " " + N5 + " + " + E1 + " " + E2;
        }

        public Boolean vencedor(int N1, int N2, int N3, int N4, int N5, int E1, int E2)
        {
            if (
                numeros.Contains(N1) &&
                numeros.Contains(N2) &&
                numeros.Contains(N3) &&
                numeros.Contains(N4) &&
                numeros.Contains(N5) &&
                estrelas.Contains(E1) &&
                estrelas.Contains(E2)
            )
            {
                return true;
            }
            return false;
        }

    }
}
