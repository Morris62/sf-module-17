using Adapter.Devices;

var imageDrawer = new ImageDrawer();

var paperPrinter = new PaperPrinter();
imageDrawer.DrawWith(paperPrinter);

var canvasPainter = new CanvasPainter();

var imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);
imageDrawer.DrawWith(imagePrinter);