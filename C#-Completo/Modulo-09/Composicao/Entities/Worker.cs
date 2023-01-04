using System;
using System.Collections.Generic;
using Composicao.Entities.Enums;

namespace Composicao.Entities
{
    public class Worker
    {
        public String name { get; set; }
        public WorkerLevel level { get; set; }
        public Double baseSalary { get; set; }
        public List<HourContract> contratos { get; set;} = new List<HourContract>();

        public Worker(string _name, WorkerLevel _level, Double _baseSalary)
        {
            name = _name;
            level = _level;
            baseSalary = _baseSalary;
        }

        public void addContract(HourContract contract)
        {
            Console.Write("Date (DD/MM/YYYY): ");
            contract.Date = DateTime.Parse(Console.ReadLine());

            Console.Write("Value per Hour: ");
            contract.valuePerHour = Double.Parse(Console.ReadLine());

            Console.Write("Duration: ");
            contract.hours = int.Parse(Console.ReadLine());

            contratos.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            contract = null;
            GC.Collect();
        }

        public Double income(int year, int Month)
        {   
            Double total = baseSalary;
            
            foreach (HourContract contrato in contratos)
            {
                if (contrato.Date.Month == Month && contrato.Date.Year == year)
                {
                    total += contrato.totalValue();
                }
            }
            
            return total;
        }
    }
}