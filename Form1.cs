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

    public partial class Form1 : Form
    {
        //Primeiro é preciso instalar a classe 
        //UsuarioExecucao para manipular os objetos
        UsuarioExecucao usuarioExecucao = new UsuarioExecucao();
        public Form1()
        {
            InitializeComponent();      
        }
       
        //Metodo para atualizar a List Box
        void AtualizarListBox()
        {
            //Limpar a ListBox
            //dataSource = Fonte de dados (EX: listaUsuaro)
            lstUsuario.DataSource = null;
            //Definir a fonte de dados da ListBox
            lstUsuario.DataSource = usuarioExecucao.ListarTodos();

            //Definir qual campo de Usuario será exibido na ListBox
            //DisplayMember o dado será exibido na list 
            //é preciso colocar o nome correto do atributo desejado
            lstUsuario.DisplayMember = "NomeEmail";
        }

        //metodo para extrair o objeto Usuario 
        //selecionada da ListBox
        Usuario ExtrairUsuario()
        {
            //recuperar o registro selecionado
            //e transformar em um objeto Usuario
            //usar o as para converter o item em objeto 
            return lstUsuario.SelectedItem as Usuario;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Vamos popular o objeto com os dados informados

            //nesse caso para ser mais objetivo, iremos pular a parte de validação(Ex: Campo vazio)

            //foco é a manipulação do objeto e da lista 

            //criar uma instancia do objeto Usuario
            Usuario usuario = new Usuario();

            //atribuir as informações ao objeto usuario
            usuario.CPF = txtCPF.Text;
            usuario.Nome = txtNome.Text;
            usuario.DtNascimento = dtpDtNascimento.Value;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            //adicionar o objeto a lista de objetos usando o metodo Adicionar de classe usuarioExecucao
            usuarioExecucao.Adicionar(usuario);

            //atualizar a ListBox para exebir o novo usuario
            AtualizarListBox();

            //Limpeza dos campos
            txtCPF.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            dtpDtNascimento.Value = DateTime.Now;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Iremos chamar o metodo ExtrairUsuario para recuperar o usuario selecionado
            //e passar este usuario para o metodo Remover da classe usuarioExecucao
            usuarioExecucao.Remover(ExtrairUsuario());

            //atualizar a ListBox para exibir a lista atualizada
            AtualizarListBox();
        }

        private void lstUsuario_DoubleClick(object sender, EventArgs e)
        {
            //Chamar o metodo ExtrairUsuario  para recuperar o usuario selecionado
            Usuario usuarioSelecionado = ExtrairUsuario();

            //exibir os dados na parte de visualização 
            txtVisCPF.Text = usuarioSelecionado.CPF;
            txtVisNome.Text = usuarioSelecionado.Nome;
            txtVisEmail.Text = usuarioSelecionado.Email;
            txtVisSenha.Text = usuarioSelecionado.Senha;
            txtVisDtNascimento.Text = usuarioSelecionado.DtNascimento.ToShortDateString();
            txtVisIdade.Text = usuarioSelecionado.Idade.ToString();
        }
    }
}
