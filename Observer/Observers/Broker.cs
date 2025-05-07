namespace Observer.Observers;

public class Broker : IObserver
{
    private IObservable? _stock;

    public Broker(IObservable? stock)
    {
        _stock = stock;
        stock?.RegisterObserver(this);
    }

    public void Update(object o)
    {
        var sData = (StockData)o;
        if (sData.EUR > 120)
        {
            Console.WriteLine($"Брокер продает евро по курсу {sData.EUR}");
        }
        else
        {
            Console.WriteLine($"Брокер покупает евро по курсу {sData.EUR}");
        }
    }

    public void StopTrade()
    {
        _stock?.RemoveObserver(this);
        _stock = null;
    }
}