using System;

class Aula10
{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado};

    static void Main()
    {
        // Enumeração - Cria tipos personalizados e valores para esse tipo
        
        int ds = (int) DiasSemana.Sexta;
        
        DiasSemana d = (DiasSemana)3;

        Console.WriteLine(ds);
    }
}