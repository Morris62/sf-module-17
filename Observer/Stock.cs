using Observer.Observers;

namespace Observer;

public class Stock : IObservable
{
    private StockData _sData = new();
    private List<IObserver> _observers = new();


    public void RegisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        _observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_sData);
        }
    }

    public void Market()
    {
        Random rnd = new();
        _sData.USD = rnd.Next(80, 110);
        _sData.EUR = rnd.Next(90, 130);
        NotifyObservers();
    }
}