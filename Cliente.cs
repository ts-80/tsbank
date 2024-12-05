using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsBank
{
    public class Cliente
    {
        public Cliente()
        {
            this.Id = 0;
            this.Nome = "";
            this.IdSocial ="";
            this.TipoConta = "";
        }

        public Cliente(int id, String nome, String idSocial, String tipoConta)
        {
            this.Id = id;
            this.Nome = nome;
            this.IdSocial = idSocial;
            this.TipoConta = tipoConta;
        }

        

        public int Id { get; set; }
        public String Nome { get; set; }
        public String IdSocial { get; set; }

        public String TipoConta { get; set; }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Parabens {this.Nome} sua conta foi aberta seu id é {this.Id}");
        }

    }
}
