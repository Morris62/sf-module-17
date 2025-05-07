namespace Observer.Observers;

public class Bank : IObserver
{
    private readonly IObservable? _stock;

    public Bank(IObservable? stock)
    {
        _stock = stock;
        stock?.RegisterObserver(this);
    }

    public void Update(object o)
    {
        var sData = (StockData)o;
        if (sData.USD > 100)
        {
            Console.WriteLine($"Банк продает доллар по курсу {sData.USD}");
        }
        else
        {
            Console.WriteLine($"Банк покупает доллар по курсу {sData.USD}");
        }
    }
}