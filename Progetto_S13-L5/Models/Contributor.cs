using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_S13_L5.Models
{
    public class Contributor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public string CF { get; set; }
        public string Gender { get; set; }
        public string TownOfResidence { get; set; }
        public double AnnualIncome { get; set; }

        protected const int stagger1 = 15000;
        protected const int stagger2 = 28000;
        protected const int stagger3 = 55000;
        protected const int stagger4 = 75000;

        public Contributor(
            string name,
            string surname,
            DateTime birthday,
            string fiscalCode,
            string gender,
            string residence,
            double income
        )
        {
            Name = name;
            Surname = surname;
            BirthDay = birthday;
            CF = fiscalCode;
            Gender = gender;
            TownOfResidence = residence;
            AnnualIncome = income;
        }

        public double CalculateTax()
        {
            double tax = 0;
            switch (AnnualIncome)
            {
                case <= stagger1:
                    tax = AnnualIncome * 0.23;
                    return tax;

                case <= stagger2:
                    tax = 3450 + (AnnualIncome - stagger1) * 0.27;
                    return tax;

                case <= stagger3:
                    tax = 6960 + (AnnualIncome - stagger2) * 0.38;
                    return tax;

                case <= stagger4:
                    tax = 17220 + (AnnualIncome - stagger3) * 0.41;
                    return tax;

                default:
                    tax = 25420 + (AnnualIncome - stagger4) * 0.43;
                    return tax;
            }
        }

        public void ShowAllInfos()
        {
            Console.Clear();
            Console.WriteLine($"Contributor: {Name} {Surname},");
            Console.WriteLine($"born on {BirthDay.ToShortDateString()} ({Gender}),");
            Console.WriteLine($"resident in {TownOfResidence},");
            Console.WriteLine($"fiscal code: {CF}");
            Console.WriteLine($"Declared income: €{AnnualIncome}");
            Console.WriteLine($"TAX TO PAY: €{CalculateTax()}");
        }
    }
}
