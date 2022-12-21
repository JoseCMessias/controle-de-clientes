using System;
using desenvolvimento_de_sistema_de_controle_de_clientes.Models;

namespace Senai
{
    class Program
    {
        static void Main(string[] args)
        {
            float ValPag;
            Console.Write("Informe o Nome: ");
            var varNome = Console.ReadLine();
            Console.Write("Informe o Endereço: ");
            var varEndereco = Console.ReadLine();
            Console.Write("Pessoa Física (f) ou Jurídica (j): ");
            var varTipo = Console.ReadLine().ToLower();


            switch (varTipo)
            {
                case "f":
                    // Pessoa Física
                    PessoaFisica pf = new PessoaFisica();
                    pf.Nome = varNome;
                    pf.Endereco = varEndereco;
                    Console.Write("Informe o seu CPF: ");
                    pf.Cpf = Console.ReadLine();
                    Console.Write("Informe o seu RG: ");
                    pf.Rg = Console.ReadLine();
                    Console.Write("Informe o Valor de compra: ");
                    ValPag = float.Parse(Console.ReadLine());
                    pf.PagarImposto(ValPag);
                    Console.WriteLine("-------- Pessoas Física --------");
                    Console.WriteLine($"Nome ..........: {pf.Nome}");
                    Console.WriteLine($"Endereço ......: {pf.Endereco}");
                    Console.WriteLine($"CPF ...........: {pf.Cpf}");
                    Console.WriteLine($"RG ............: {pf.Rg}");
                    Console.WriteLine($"Valor de compra: {pf.Valor.ToString("C")}");
                    Console.WriteLine($"Imposto .......: {pf.ValorImposto.ToString("C")}");
                    Console.WriteLine($"Total .........: {pf.Total.ToString("C")}");
                    break;

                case "j":
                    // Pessoa Jurídica 
                    PessoasJuridica pj = new PessoasJuridica();
                    pj.Nome = varNome;
                    pj.Endereco = varEndereco;
                    Console.Write("Informe o seu CNPJ: ");
                    pj.Cnpj = Console.ReadLine();
                    Console.Write("Informe o seu IE: ");
                    pj.Ie = Console.ReadLine();
                    Console.Write("Informe o Valor de compra: ");
                    ValPag = float.Parse(Console.ReadLine());
                    pj.PagarImposto(ValPag);
                    Console.WriteLine("-------- Pessoas Jurídica --------");
                    Console.WriteLine($"Nome ..........: {pj.Nome}");
                    Console.WriteLine($"Endereço ......: {pj.Endereco}");
                    Console.WriteLine($"CNPJ ...........: {pj.Cnpj}");
                    Console.WriteLine($"IE ............: {pj.Ie}");
                    Console.WriteLine($"Valor de compra: {pj.Valor.ToString("C")}");
                    Console.WriteLine($"Imposto .......: {pj.ValorImposto.ToString("C")}");
                    Console.WriteLine($"Total .........: {pj.Total.ToString("C")}");
                    break;
                default:
                    Console.WriteLine("Função inexistente!");
                    Console.WriteLine("Digite F ou J");
                    break;

            }


        }
    }
}