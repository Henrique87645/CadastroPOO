using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    public class FuncionarioPJ : Funcionario
    {
        public FuncionarioPJ(string nome, string cpf, DateTime dtAdmissao, decimal salarioBase)
        {
            Nome = nome;
            CPF = cpf;
            DtAdmissao = dtAdmissao;
            SalarioBase = salarioBase;
        }

        // PJ recebe o salário integral (sem descontos fixos)
        public decimal CalcularSalarioLiquido()
        {
            return SalarioBase;
        }
    }
}
