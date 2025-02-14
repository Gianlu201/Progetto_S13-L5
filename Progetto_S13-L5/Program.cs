using Progetto_S13_L5.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Title = "EPITAX";
string intestation = "====== WELCOME IN EPITAX ======\n";

bool error = false;

string? name = "";
while (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name))
{
    Console.Clear();
    Console.SetCursorPosition((Console.WindowWidth - intestation.Length) / 2, Console.CursorTop);
    Console.WriteLine(intestation);
    if (error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Information required!");
        Console.ResetColor();
    }
    Console.Write("What's your name: ");
    name = Console.ReadLine();
    error = true;
}

error = false;
string? surname = "";
while (string.IsNullOrWhiteSpace(surname) || string.IsNullOrEmpty(surname))
{
    Console.Clear();
    Console.SetCursorPosition((Console.WindowWidth - intestation.Length) / 2, Console.CursorTop);
    Console.WriteLine(intestation);
    if (error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Information required!");
        Console.ResetColor();
    }
    Console.Write("What's your surname: ");
    surname = Console.ReadLine();
    error = true;
}

error = false;
string? birthdayStr = "";
DateTime birthday;
do
{
    Console.Clear();
    Console.SetCursorPosition((Console.WindowWidth - intestation.Length) / 2, Console.CursorTop);
    Console.WriteLine(intestation);
    if (error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Check date form!");
        Console.ResetColor();
    }
    Console.Write("What's your birthday (DD/MM/YYYY): ");
    birthdayStr = Console.ReadLine();
    error = true;
} while (birthdayStr?.Length != 10 || !DateTime.TryParse(birthdayStr, out birthday));

error = false;
string? fiscalCode = "";
while (string.IsNullOrWhiteSpace(fiscalCode) || string.IsNullOrEmpty(fiscalCode))
{
    Console.Clear();
    Console.SetCursorPosition((Console.WindowWidth - intestation.Length) / 2, Console.CursorTop);
    Console.WriteLine(intestation);
    if (error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Information required!");
        Console.ResetColor();
    }
    Console.Write("What's your fiscal code: ");
    fiscalCode = Console.ReadLine();
    error = true;
}

error = false;
string? gender = "";
while (gender?.ToLower() is not "m" and not "f" and not "o")
{
    Console.Clear();
    Console.SetCursorPosition((Console.WindowWidth - intestation.Length) / 2, Console.CursorTop);
    Console.WriteLine(intestation);
    if (error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Choose one of the options!");
        Console.ResetColor();
    }
    Console.Write("What's your gender (M/F/O): ");
    gender = Console.ReadLine();
    error = true;
}

error = false;
string? residence = "";
while (string.IsNullOrWhiteSpace(residence) || string.IsNullOrEmpty(residence))
{
    Console.Clear();
    Console.SetCursorPosition((Console.WindowWidth - intestation.Length) / 2, Console.CursorTop);
    Console.WriteLine(intestation);
    if (error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Information required!");
        Console.ResetColor();
    }
    Console.Write("What's your town of residence: ");
    residence = Console.ReadLine();
    error = true;
}

error = false;
string? incomeStr = "";
double income;
do
{
    Console.Clear();
    Console.SetCursorPosition((Console.WindowWidth - intestation.Length) / 2, Console.CursorTop);
    Console.WriteLine(intestation);
    if (error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Check your answer!");
        Console.ResetColor();
    }
    Console.Write("What's your annual income (Ex. 17850,40): ");
    incomeStr = Console.ReadLine();
    error = true;
} while (!double.TryParse(incomeStr, out income));

var user = new Contributor(name, surname, birthday, fiscalCode, gender, residence, income);

user.ShowAllInfos();

Console.ReadKey();
