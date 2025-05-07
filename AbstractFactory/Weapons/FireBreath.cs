namespace AbstractFactory.Weapons;

public class FireBreath : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Дышим огнем");
    }
}