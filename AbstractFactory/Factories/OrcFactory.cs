using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories;

public class OrcFactory : IMonsterFactory
{
    public IMovement CreateMovement()
    {
        return new RunMovement();
    }

    public IWeapon CreateWeapon()
    {
        return new Axe();
    }
}