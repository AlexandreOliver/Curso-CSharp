namespace Entities;

class PessoaJuridica : Contribuintes
{
    public int numeroFuncionario { get; set; }

    public PessoaJuridica(string nome, double rendaAnual, int nFuncio)
        : base(nome, rendaAnual)
    {
        numeroFuncionario = nFuncio;
    }

    public override double Imposto()
    {
        double taxa = 0.0;

        taxa = (numeroFuncionario < 10) ? 0.16 : 0.14;

        double total = base.RendaAnual * taxa;

        return total;
    }
}