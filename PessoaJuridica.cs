using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsBank
{
    public class PessoaJuridica:Cliente
    {

        

        public PessoaJuridica():base()
        {
            this.Cnpj = "";
            this.Pj = "";
        }
        public PessoaJuridica(int id, String nome, String cnpj, String pj):base(id, nome, cnpj, pj)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Pj = pj;
        }
        public String Cnpj { get; set; }

        public String Pj { get; set; }

        public override void ExibirDados()
        {
            Console.WriteLine($"Parabens {this.Nome} sua conta pessoa jurídica foi aberta seu id é {this.Id}");
        }
    }
}
