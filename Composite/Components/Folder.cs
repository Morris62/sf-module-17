namespace Composite.Components;

public class Folder(string name) : Component(name)
{
    private readonly List<Component> SubFolders = new();

    public override void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"{Name} содержит:");
        foreach (var subFolder in SubFolders)
        {
            subFolder.Display();
        }
    }

    public override void Add(Component c)
    {
        SubFolders.Add(c);
        Console.WriteLine($"В {Name} добавлено {c.Name}");
    }

    public override void Remove(Component c)
    {
        SubFolders.Remove(c);
        Console.WriteLine($"Из {Name} удалено {c.Name}");
    }
}