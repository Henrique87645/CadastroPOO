using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    //Calsse para manipular o objeto Usuário
    public class UsuarioExecucao
    {
        //Criar uma lista para armazenar 
        //um conjunto de objetos(Usuarios)

        //Tornar a lista privada para somente 
        //classe UsuarioExecucao ter acesso
        private List<Usuario> ListaUsuario = new List<Usuario>();

        //Metodo para adicionar o usuario a lista
        public void Adicionar(Usuario usuario)
        {
            ListaUsuario.Add(usuario);
        }

        //Metodo para remover um usuario da lista
        public void Remover(Usuario usuario)
        {
            ListaUsuario.Remove(usuario);
        }

        //metodo que retorna todos os usuarios
        //retorna a propria lista
        public List<Usuario> ListarTodos()
        {
            return ListaUsuario;
        }
    }
}
