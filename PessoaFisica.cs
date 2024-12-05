using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsBank
{
    public class PessoaFisica:Cliente
    {

        public PessoaFisica():base()
        {
            this.Cpf = "";
            this.Pf = "";
        }

        public PessoaFisica(int id, String nome, String cpf, String pf):base(id, nome,cpf, pf)
        {
            this.Cpf = cpf;
            this.Pf = Pf;
        }


        
        public String Cpf { get; set; }

        public String Pf { get; set; }

        public override void ExibirDados()
        {
            Console.WriteLine($"Parabens {this.Nome} sua conta pessoa física foi aberta seu id é {this.Id}");
        }

    }
}
