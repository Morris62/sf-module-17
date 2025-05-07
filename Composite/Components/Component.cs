namespace Composite.Components;

public abstract class Component(string name)
{
    public readonly string Name = name;

    public abstract void Display();
    public abstract void Add(Component c);
    public abstract void Remove(Component c);
}