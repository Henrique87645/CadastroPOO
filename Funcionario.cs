using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public decimal SalarioBase { get; set; }
        public DateTime DtAdmissao { get; set; }

        public int TempoDeServico
        {
            get
            { 
                DateTime dataAtual = DateTime.Now;
                int TempoDeServico = dataAtual.Year - DtAdmissao.Year;
                if (dataAtual.Month < DtAdmissao.Month || (dataAtual.Month == DtAdmissao.Month && dataAtual.Day < DtAdmissao.Day))
                {
                    TempoDeServico--;
                }
                //Por ultimo retorna o TempoDeServico 
                return TempoDeServico;
            }
        }

    }
}
