namespace Facade.Components;

public class Editor
{
    public void Write(string code)
    {
        Console.WriteLine($"Пишем код: {code}");
    }

    public void Save()
    {
        Console.WriteLine("Сохраняем код");
    }
}