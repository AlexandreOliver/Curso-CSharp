using System;

class Aula11
{
    static void Main()
    {
        /*                  Conversão de Tipos Implicitas
        
        sbyte ---> short, int, long, float, double, decimal ou nint
        byte ----> short, ushort, int, uint, long, ulong, float, double, decimal, nint ou nuint
        short ---> int, long, float, doubleou decimal, ou nint
        ushort --> int, uint, long, ulong, float, ou double, nintou decimal, ounuint
        int -----> long, floatou doubledecimal,nint 
        Uint ----> long, ulong, float, double ou decimal, ou , ou nuint
        longo ---> float, double ou decimal
        ulong ---> float, double ou decimal
        floa ----> double
        nint ----> long, float, double ou decimal
        nuint ---> ulong, float, double ou decimal

        */

        /*                  Conversao de Tipos Explicitas

        sbyte -----> byte, ushort, uint, ulong ou nuint
        byte ------> sbyte
        short -----> sbyte, byte, ushort, uint, ulong ou nuint
        ushort ----> sbyte, byte ou short
        int	-------> sbyte, byte, short, ushort, uint, ulong ou nuint
        Uint ------> sbyte, byte, short, ushort ou int
        longo -----> sbyte, byte, short, ushort, int, uint, ulong, nint ou nuint
        ulong -----> sbyte, byte, short, ushort, int, uint, long, nint ou nuint
        float -----> sbyte, byte, short, ushort, int, uint, long, ulong, decimal, nint ou nuint
        double ----> sbyte, byte, short, ushort, int, ,uint, long, ulong, float, decimal, , nint, ou nuint
        decimal ---> sbyte, byte, short, ushort, int, ,uint, long, ulong, float, double, , nint, ou nuint
        nint ------> sbyte, byte, short, ushort, int, uint, ulong ou nuint
        nuint -----> sbyte, byte, short, ushort, int, uint, long ou nint

        */

        // Conversao implicita de Int para Float
        int n1 = 10;
        float n2 = n1;
        Console.WriteLine(n2);

        // Conversao Explicita de Float para Int
        float n3 = 11.5f;
        int n4 = (int)n3;    // (int) - Operação de type cast
        Console.WriteLine(n4);
        
        // Conversao Implicita de Int para Long Int
        int n5=12;
        long n6 = n5;
        Console.WriteLine(n6);

        // Conversao Explicita de Int para short
        int n7 = 13;
        short n8 = (short) n7;
        Console.WriteLine(n8);

    }
}