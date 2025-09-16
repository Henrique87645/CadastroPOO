using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    public class FuncionarioEstagiario : Funcionario
    {
        public FuncionarioEstagiario(string nome, string cpf, DateTime dtAdmissao, decimal salarioBase)
        {
            Nome = nome;
            CPF = cpf;
            DtAdmissao = dtAdmissao;
            SalarioBase = salarioBase;
        }

        // Estagiário recebe 80% do salário base (simulação de bolsa)
        public decimal CalcularSalarioLiquido()
        {
            return SalarioBase * 0.8m;
        }
    }
}
