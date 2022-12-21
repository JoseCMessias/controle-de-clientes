namespace desenvolvimento_de_sistema_de_controle_de_clientes.Models
{
    public class PessoasJuridica : Cliente
    {
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
