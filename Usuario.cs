using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    //Usuario herda de Pessoa
    //Recebe tudo o que estiver publico 
    //Sinal de dois pontos (:) significa que a classe atual está herdando
    //de outra classe
    public class Usuario : Pessoa
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public string NomeEmail
        {
            get
            {
                return CPFNome + " - " + Email;
                //Ex: 12345678901 - Henrique@gmail.com
            }
        }
    }
}
