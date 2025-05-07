namespace State.States;

public class UpperElevatorState : IElevatorState
{
    public void Up(Elevator elevator)
    {
        Console.WriteLine("Поднимаемся еще выше");
    }

    public void Down(Elevator elevator)
    {
        Console.WriteLine("Опускаемся на первый этаж");
        elevator.ElevatorState = new GroundElevatorState();
    }
}