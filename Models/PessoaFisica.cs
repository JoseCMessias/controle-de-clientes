using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desenvolvimento_de_sistema_de_controle_de_clientes.Models
{
    public class PessoaFisica : Cliente
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}
