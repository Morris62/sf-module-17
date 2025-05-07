namespace Adapter.Devices;

public class CanvasPainter : IPainter
{
    public void Print()
    {
        Console.WriteLine("Рисуем на холсте");
    }
}