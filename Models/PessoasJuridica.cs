using System;

namespace desenvolvimento_de_sistema_de_controle_de_clientes.Models
{
    internal class PessoasJuridica : Cliente
    {
        public PessoasJuridica(float valor) : base(valor)
        {
        }

        public string Cnpj { get; set; }
        public string Ie { get; set; }

        public override void PagarImposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
