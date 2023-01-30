namespace Entities;

class PessoaFisica : Contribuintes
{
    public double GastosSaude { get; set; }

    public PessoaFisica(string nome, double rendaAnual, double gastosSaude)
        : base(nome, rendaAnual)
    {
        GastosSaude = gastosSaude;
    }

    public override double Imposto()
    {
        double taxa = 0.0;
        
        taxa = (RendaAnual < 20000.00) ? 0.15 : 0.25;

        double total = base.RendaAnual * taxa;

        if (GastosSaude > 0)
        {
            total -= GastosSaude * 0.5; 
        }

        return total;
    }
}