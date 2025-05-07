using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories;

public class DragonFactory : IMonsterFactory
{
    public IMovement CreateMovement()
    {
        return new FlyMovement();
    }

    public IWeapon CreateWeapon()
    {
        return new FireBreath();
    }
}