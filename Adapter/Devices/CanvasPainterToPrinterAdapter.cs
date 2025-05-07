namespace Adapter.Devices;

public class CanvasPainterToPrinterAdapter(CanvasPainter painter) : IPrinter
{
    public CanvasPainter Painter { get; private set; } = painter;

    public void Print()
    {
        painter.Print();
    }
}