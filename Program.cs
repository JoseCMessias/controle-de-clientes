using System;
using desenvolvimento_de_sistema_de_controle_de_clientes.Models;

namespace Senai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______ Pessoa Fisica: ______");
            Console.WriteLine();
            float adcionarValor = float.Parse(Console.ReadLine());

            PessoaFisica pf = new PessoaFisica(adcionarValor);
            pf.Nome = "João Messias";
            pf.Cpf = "111.222.333-44";
            pf.Rg = "1.222.333";
            pf.Endereco = "Rua 22";

            Console.WriteLine($"Olá {pf.Nome} e {pf.Total}");
            
        }
    }
}