using System;
using System.Collections.Generic;
using Atividade1.Entities.Enums;

namespace Atividade1.Entities
{
    public class Worker
    {
        public String name { get; set; }
        public WorkerLevel level { get; set; }
        public Double baseSalary { get; set; }
        public Department department { get; set;}
        public List<HourContract> contratos { get; set;} = new List<HourContract>();

        public Worker(string _name, WorkerLevel _level, Double _baseSalary, Department _department)
        {
            name = _name;
            level = _level;
            baseSalary = _baseSalary;
            department = _department;
        }

        public void addContract(HourContract contract)
        {
            contratos.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            contratos.Remove(contract);
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