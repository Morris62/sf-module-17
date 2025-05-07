namespace AbstractFactory.Movements;

public class FlyMovement : IMovement
{
    public void Start()
    {
        Console.WriteLine("Летим");
    }
}