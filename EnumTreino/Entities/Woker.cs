using EnumTreino.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using EnumTreino.Entities.Enums;

namespace EnumTreino.Entities
{
    class Woker
    {
        public string Name { get; private set; }
        public WokerLevel Level { get;  private set; }
        public double BaseSalary { get;private set; }
        public Department department { get; private set; }

        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Woker(string name, WokerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            this.department = department;
        }


        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month) 
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDepartment: {department.Name}";
        }
    }
}
