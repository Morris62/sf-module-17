using State.States;

namespace State;

public class Elevator(IElevatorState elevatorState)
{
    public IElevatorState ElevatorState { get; set; } = elevatorState;

    public void Up()
    {
        ElevatorState.Up(this);
    }

    public void Down()
    {
        ElevatorState.Down(this);
    }
}