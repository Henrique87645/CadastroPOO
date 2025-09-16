using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPOO
{
    public partial class Form2 : Form
    {
        private SistemaExecucao sistemaExecucao = new SistemaExecucao();
        public Form2()
        {
            InitializeComponent();
        }
        void AtualizarListBox()
        {
            lstUsuario.DataSource = null;
            lstUsuario.DataSource = sistemaExecucao.ListarTodos();
        }

        Funcionario ExtrairFuncionario()
        {
            return lstUsuario.SelectedItem as Funcionario;
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            try // Bloco try-catch para capturar erros
            {
                string nome = txtNome.Text;
                string cpf = txtCPF.Text;
                decimal salarioBase = Convert.ToDecimal(txtSalBase.Text);
                DateTime dtAdmissao = dtpDtAdmissao.Value;


                Funcionario novoFuncionario = null;

                if (rbCLT.Checked) // Verifica se o RadioButton CLT está selecionado
                    novoFuncionario = new FuncionarioCLT(nome, cpf, dtAdmissao, salarioBase);
                else if (rbPJ.Checked) // Verifica se o RadioButton PJ está selecionado
                    novoFuncionario = new FuncionarioPJ(nome, cpf, dtAdmissao, salarioBase);
                else if (rbEstagiario.Checked) // Verifica se o RadioButton Estagiário está selecionado
                    novoFuncionario = new FuncionarioEstagiario(nome, cpf, dtAdmissao, salarioBase);

                if (novoFuncionario != null)
                {
                    sistemaExecucao.Adicionar(novoFuncionario); ;
                    AtualizarListBox(); // Atualiza a ListBox após adicionar o funcionário
                }

                // Limpeza dos campos
                txtNome.Clear();
                txtCPF.Clear();
                txtSalBase.Clear();
                dtpDtAdmissao.Value = DateTime.Now;
                rbCLT.Checked = rbPJ.Checked = rbEstagiario.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }


        }
        private void sbtnListaFuncionario_Click(object sender, EventArgs e)
        {
            AtualizarListBox();
        }

        private void btnCalFolhaTotal_Click(object sender, EventArgs e)
        {
            txtFolhaCLT.Text = sistemaExecucao.CalcularFolhaCLT().ToString("C2");
            txtFolhaPJ.Text = sistemaExecucao.CalcularFolhaPJ().ToString("C2");
            txtFolhaEstagiario.Text = sistemaExecucao.CalcularFolhaEstagiario().ToString("C2");
        }

        private void btnLimparCads_Click(object sender, EventArgs e)
        {
            sistemaExecucao.Remover(ExtrairFuncionario());
            AtualizarListBox();

            // Limpar folhas de pagamento
            txtFolhaCLT.Clear();
            txtFolhaPJ.Clear();
            txtFolhaEstagiario.Clear();
        }
    }
}
