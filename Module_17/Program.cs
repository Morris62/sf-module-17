namespace Module_17;

class Program
{
    static void Main(string[] args)
    {
        var salaryAccount = new SalaryAccount(1100);
        var regularAccount = new RegularAccount(900);

        Calculator.CalculateInterest(salaryAccount);
        Console.WriteLine("Зарплатный счет");
        Console.WriteLine(salaryAccount);
        
        Console.WriteLine();
        
        Calculator.CalculateInterest(regularAccount);
        Console.WriteLine("Обычный счет");
        Console.WriteLine(regularAccount);
    }
}