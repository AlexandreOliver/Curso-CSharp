namespace Entities;

abstract class Contribuintes
{
    public string Name { get; set; }
    public double RendaAnual { get; set; }

    public Contribuintes(string nome, double rendaAnual)
    {
        Name = nome;
        RendaAnual = rendaAnual;
    }

    public abstract double Imposto();
}