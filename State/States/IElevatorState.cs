namespace State.States;

public interface IElevatorState
{
    void Up(Elevator elevator);
    void Down(Elevator elevator);
}