using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoSantaCasa
{
    class JogosSantaCasa
    {
        //Variaveis Membro
        protected string m_str_nomeJogo;
        protected DateTime m_dtm_dataAposta;
        protected DateTime m_dtm_dataSorteio;
        protected double m_dbl_valorAposta;
        protected double m_dbl_valorPremio;
        protected string m_str_chaveCompleta;


        //Propriedades
        public string NomeJogo
        {
            get
            {
                return m_str_nomeJogo;
            }
        }
        private DateTime DataAposta
        {
            get
            {
                return m_dtm_dataAposta;
            }
        }
        private DateTime DataSorteio
        {
            get
            {
                return m_dtm_dataSorteio;
            }
        }
        private double ValorAposta
        {
            get
            {
                return m_dbl_valorAposta;
            }
        }
        private double ValorPremio
        {
            get
            {
                return m_dbl_valorPremio;
            }
        }

        public string ChaveCompleta { get { return m_str_chaveCompleta; } }

        public JogosSantaCasa() { }
        //Método construtor
        public JogosSantaCasa(string NomeJogo, DateTime DataAposta, DateTime DataSorteio, double ValorAposta, double ValorPremio)
        {
            m_str_nomeJogo = NomeJogo;
            m_dtm_dataAposta = DataAposta;
            m_dtm_dataSorteio = DataSorteio;
            m_dbl_valorAposta = ValorAposta;
            m_dbl_valorPremio = ValorPremio;
        }
    }
}
