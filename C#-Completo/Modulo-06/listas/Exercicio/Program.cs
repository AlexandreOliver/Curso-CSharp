using System;
using System.Collections.Generic;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
        List<Employee> funcionarios = new List<Employee>();

        Console.Write("How many employees will be registred? ");
        int quant = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quant; i++)
        {
            Console.WriteLine($"\nEmployoee #{i}:");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());

            funcionarios.Add(new Employee(id, nome, salary));
        }

        Console.Write("\nEnter the employee id that will have salary increase: ");
        int idx = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the percentage: ");
        double perc = double.Parse(Console.ReadLine());

        int count = 0;
        foreach (var i in funcionarios)
        {
            if (i.id == idx)
            {
                i.increaseSalary(perc);
                count +=1;
            }
        }
        
        if (count == 0)
        {
            Console.WriteLine("This id does not exist!");
        }
        
        Console.WriteLine("\nUpdate list of employees: ");
        foreach (var i in funcionarios)
        {
            Console.WriteLine(i);
        }
    }


 class Employee
  {
    public int id;
    public string name;
    public double salary;

    public Employee(int idx, string nome, double salario)
    {
        id = idx;
        name = nome;
        salary = salario;
    }

    public override string ToString()
    {
        return $"{id}, {name}, {salary}";
    }

    public void increaseSalary(double percentage)
    {
        salary *= (1.0 + percentage/100);
    }

   }
}
}
