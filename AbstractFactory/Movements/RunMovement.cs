namespace AbstractFactory.Movements;

public class RunMovement : IMovement
{
    public void Start()
    {
        Console.WriteLine("Бежим");
    }
}