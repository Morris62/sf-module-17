using State;
using State.States;

var elevator = new Elevator(new GroundElevatorState());

elevator.Up();
elevator.Down();
elevator.Down();