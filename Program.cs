using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf;
            PessoaJuridica pj;
            int op1=100;
            String tipoConta = "";
            int cont = 1;
            string cpf;
            string cnpj;
            string nome;
            int id;
            int servicos;
            string perfilConta = "";

            List<Cliente> cliente = new List<Cliente>();

            while (op1 != 0)
            {
                
                Console.WriteLine("Bem vindo ao TSBANK.");
                Console.Write("Caso deseje abrir uma conta informe a opção 1, para outras questões informe 2 caso queira sair informe 0: ");
                op1 = int.Parse(Console.ReadLine());
                try
                {
                    switch (op1)
                    {
                        case 1:
                            Console.Write("Informe PF dedeseja abrir uma conta pessoa fisica ou PJ se deseja abrir uma conta juridica: ");
                            tipoConta = Console.ReadLine();
                            if (tipoConta.ToUpper() == "PF")
                            {
                                Console.Write("Informe seu nome: ");
                                nome = Console.ReadLine();
                                Console.Write("Informe seu cpf: ");
                                cpf = Console.ReadLine();
                                id = cont;
                                perfilConta = "F";
                                pf = new PessoaFisica(id, nome, cpf, perfilConta);
                                cliente.Add(pf);
                                pf.ExibirDados();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (tipoConta.ToUpper() == "PJ")
                            {
                                Console.Write("Informe seu nome: ");
                                nome = Console.ReadLine();
                                Console.Write("Informe seu cnpj: ");
                                cnpj = Console.ReadLine();
                                id = cont;
                                perfilConta = "J";
                                pj = new PessoaJuridica(id, nome, cnpj, perfilConta);
                                cliente.Add(pj);
                                pj.ExibirDados();
                                Console.ReadKey();
                                Console.Clear();
                            }                    
                            break;

                        case 2:
                            string validador;
                            //string cInfo = "";
                            Console.WriteLine("Olá! escolha entra as opções abaixo para que possamos lhe direcionar para a central de atendimento correta!");
                            Console.WriteLine("1 - Saldos!");
                            Console.WriteLine("2 - Emprestimos!");
                            Console.WriteLine("3 - Limites");
                            Console.WriteLine("4 - Duvidas");
                            servicos = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Informe seu nome por favor: ");
                            validador = Console.ReadLine();
                            foreach (Cliente clientes in cliente)
                            {

                                if (clientes.TipoConta == "F" & clientes.Nome.ToUpper() == validador.ToUpper())
                                {
                                    Console.WriteLine($"Olá {clientes.Nome} para este serviço entre em contato com nosso telefone 0800 - 2536-2587 agradecemos seu contato volte sempre!");
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                                if (clientes.TipoConta == "J" & clientes.Nome.ToUpper() == validador.ToUpper())
                                {
                                    Console.WriteLine($"Olá {clientes.Nome} para este serviço acesse nosso site www.tsbank.com agradecemos seu contato volte sempre!");
                                    Console.ReadKey();
                                    Console.Clear();

                                }

                            }
                            break;
                        default:
                            
                            break;
                    }
                    
                }
                catch
                {
                    op1 = 0;
                }
                cont++;

            }
            

            Console.ReadKey();

        }
    }
}
