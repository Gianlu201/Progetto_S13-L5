using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            return AnnualIncome switch
            {
                <= stagger1 => AnnualIncome * 0.23,
                <= stagger2 => 3450 + ((AnnualIncome - stagger1) * 0.27),
                <= stagger3 => 6960 + ((AnnualIncome - stagger2) * 0.38),
                <= stagger4 => 17220 + ((AnnualIncome - stagger3) * 0.41),
                _ => 25420 + ((AnnualIncome - stagger4) * 0.43),
            };
        }

        public void ShowAllInfos()
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            Console.Clear();
            Console.WriteLine(
                $"Contributor: {myTI.ToTitleCase(Name)} {myTI.ToTitleCase(Surname)},"
            );
            Console.WriteLine($"born on {BirthDay.ToShortDateString()} ({Gender.ToUpper()}),");
            Console.WriteLine($"resident in {myTI.ToTitleCase(TownOfResidence)},");
            Console.WriteLine($"fiscal code: {CF.ToUpper()}");
            Console.WriteLine($"Declared income: €{AnnualIncome:0.00}");
            Console.WriteLine($"TAX TO PAY: €{CalculateTax():0.00}");
        }
    }
}
