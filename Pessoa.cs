using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    public class Pessoa
    {
        //criar os atributos(propriedades)
        //digitar prop e apertar TAB

        //seram leitura e gravação(Get e Set)
        //Sempre sera com primeir letra MAIUSCULA
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DtNascimento { get; set; }

        //Propriedaade somente de leitura 
        //vou acessar as informações cpf (encapsulamento)

        public string CPFNome
        {
            get
            {
                return CPF + " - " + Nome.ToUpper();
                //Ex: 12345678901 - Henrique
                //ToUpper() - retorna o testo em maiusculo
            }
        }

        //Propriedade que retorna a idade calculada com base na DtNascimento
        public int Idade
        {
            get
            {
                //para descobrir a idade realiza-se a conta
                //data atual - data de nascimento 
                //comendos: Now - recupera data atual do computador
                //Porém iremos calcular com base no dia para maior precisão
                DateTime dataAtual = DateTime.Now;
                int idade = dataAtual.Year - DtNascimento.Year;

                //Olhar com base na data 
                //se mês maior que o mes de nascimento 
                //mantemos a idade
                //Se menor remove 1 da idade 
                //Se igual validamos o dia
                //Se dia menor removemos 1 da idade 
                //Se dia igual ou superior mantemos a idade
                if (dataAtual.Month < DtNascimento.Month || (dataAtual.Month == DtNascimento.Month && dataAtual.Day < DtNascimento.Day))
                {
                    idade--;
                }
                //Por ultimo retorna a idade 
                return idade;
            }
        }
    }
}
