namespace AbstractFactory.Weapons;

public class Axe : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Бьем топором");
    }
}