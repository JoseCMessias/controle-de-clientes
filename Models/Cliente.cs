using System;

namespace desenvolvimento_de_sistema_de_controle_de_clientes.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float Valor { get; protected set; }
        public float ValorImposto { get; protected set; }
        public float Total { get; protected set; }

        public Cliente(float valor)
        {
            Valor = valor;
        }

        public virtual void PagarImposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 10 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }

    }
}
