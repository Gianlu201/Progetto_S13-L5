using Progetto_S13_L5.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("====== WELCOME IN EPITAX ======\n");

Console.Write("What's your name: ");
string name = Console.ReadLine();

Console.Clear();
Console.WriteLine("====== WELCOME IN EPITAX ======\n");
Console.Write("What's your surname: ");
string surname = Console.ReadLine();

Console.Clear();
Console.WriteLine("====== WELCOME IN EPITAX ======\n");
Console.Write("What's your birthday (DD/MM/YYYY): ");
string birthday = Console.ReadLine();

Console.Clear();
Console.WriteLine("====== WELCOME IN EPITAX ======\n");
Console.Write("What's your fiscal code: ");
string fiscalCode = Console.ReadLine();

Console.Clear();
Console.WriteLine("====== WELCOME IN EPITAX ======\n");
Console.Write("What's your gender (M/F/O): ");
string gender = Console.ReadLine();

Console.Clear();
Console.WriteLine("====== WELCOME IN EPITAX ======\n");
Console.Write("What's your town of residence: ");
string residence = Console.ReadLine();

Console.Clear();
Console.WriteLine("====== WELCOME IN EPITAX ======\n");
Console.Write("What's your annual income: ");
string income = Console.ReadLine();

var test = DateTime.Parse(birthday);

double incomeConv = double.Parse(income);

var user = new Contributor(name, surname, test, fiscalCode, gender, residence, incomeConv);

user.ShowAllInfos();

Console.ReadKey();
