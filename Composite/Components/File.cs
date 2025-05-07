namespace Composite.Components;

public class File(string name) : Component(name)
{
    public override void Display()
    {
        Console.WriteLine(Name);
    }

    public override void Add(Component c)
    {
        throw new NotImplementedException();
    }

    public override void Remove(Component c)
    {
        throw new NotImplementedException();
    }
}