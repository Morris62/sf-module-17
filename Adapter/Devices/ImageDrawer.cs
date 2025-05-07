namespace Adapter.Devices;

public class ImageDrawer
{
    public void DrawWith(IPrinter printer)
    {
        printer.Print();
    }
}