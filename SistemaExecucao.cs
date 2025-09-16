using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    public class SistemaExecucao
    {
        private List<Funcionario> ListaFuncionario = new List<Funcionario>();

        public void Adicionar(Funcionario funcionario)
        {
            ListaFuncionario.Add(funcionario);
        }

        public void Remover(Funcionario funcionario)
        {
            ListaFuncionario.Remove(funcionario);
        }

        public List<Funcionario> ListarTodos()
        {
            return ListaFuncionario;
        }

        // Folha só de CLT
        public decimal CalcularFolhaCLT()
        {
            decimal total = 0;
            foreach (var f in ListaFuncionario)
            {
                if (f is FuncionarioCLT)
                    total += ((FuncionarioCLT)f).CalcularSalarioLiquido();
            }
            return total;
        }

        // Folha só de PJ
        public decimal CalcularFolhaPJ()
        {
            decimal total = 0;
            foreach (var f in ListaFuncionario)
            {
                if (f is FuncionarioPJ)
                    total += ((FuncionarioPJ)f).CalcularSalarioLiquido();
            }
            return total;
        }

        // Folha só de Estagiário
        public decimal CalcularFolhaEstagiario()
        {
            decimal total = 0;
            foreach (var f in ListaFuncionario)
            {
                if (f is FuncionarioEstagiario)
                    total += ((FuncionarioEstagiario)f).CalcularSalarioLiquido();
            }
            return total;
        }
    }
}
