using Adapter.Devices;

public class PaperPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Печатаем на бумаге");
    }
}