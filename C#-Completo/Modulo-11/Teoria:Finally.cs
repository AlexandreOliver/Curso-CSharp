using System;

namespace Teoria
{
    class finaly
    {
        static void Main()
        {
            try 
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Vc sabe resolver uma divisao por 0? se sim ent va atras do seu nobel em matematica");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Formato Errado! Eu pedi um numero voce me passou outra coisa");
            } 
            finally //Executa logo apos o termino de try, sempre executa!
            {
                Console.WriteLine("Tchau!!");
            }
        }
    }
}