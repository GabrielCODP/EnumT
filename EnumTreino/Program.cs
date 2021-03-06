﻿using EnumTreino.Entities;
using EnumTreino.Entities.Enums;
using System;
using System.Globalization;

namespace EnumTreino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();

            Console.WriteLine("\nEnter woker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WokerLevel level = Enum.Parse<WokerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(department);
            Woker woker = new Woker(name, level, salary, dept);

            Console.Write("How many contracts to this woker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter #{i+1} contract data:");

                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, ValuePerHour, duration);

                woker.AddContract(contract); //adicionar o contrato, do trabalhador do "woker".(Dentro da memoria, vai ter o trabalhador e os contradros separados
            }

            Console.Write("\nEnter month  and year to calcule income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"\n{woker}");

            Console.Write($"Income for: {monthAndYear}: {woker.income(year, month)}");
        }
    }
}
