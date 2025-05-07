using AbstractFactory;
using AbstractFactory.Factories;

var dragon = new Monster(new DragonFactory());
dragon.Move();
dragon.Hit();
Console.WriteLine();

var orc = new Monster(new OrcFactory());
orc.Move();
orc.Hit();
Console.WriteLine();

Console.WriteLine("Finish him...");