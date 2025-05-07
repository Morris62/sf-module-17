using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories;

public interface IMonsterFactory
{
    IMovement CreateMovement();
    IWeapon CreateWeapon();
}