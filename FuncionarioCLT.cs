using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    public class FuncionarioCLT : Funcionario
    {
        public FuncionarioCLT(string nome, string cpf, DateTime dtAdmissao, decimal salarioBase)
        {
            Nome = nome;
            CPF = cpf;
            DtAdmissao = dtAdmissao;
            SalarioBase = salarioBase;
        }

        // Desconto fixo de 10% (simulação de INSS/IR)
        public decimal CalcularSalarioLiquido()
        {
            return SalarioBase * 0.9m;
        }
    }
}
