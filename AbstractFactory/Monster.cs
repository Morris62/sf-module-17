using AbstractFactory.Factories;
using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory;

public class Monster(IMonsterFactory monsterFactory)
{
    private IWeapon _weapon = monsterFactory.CreateWeapon();
    private IMovement _movement = monsterFactory.CreateMovement();

    public void Move() => _movement.Start();
    public void Hit() => _weapon.Attack();
}