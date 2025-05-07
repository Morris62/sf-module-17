namespace Facade.Components;

public class IdeFacade(Editor editor, Compiler compiler, Runtime runtime)
{
    readonly Editor _editor = editor;
    readonly Compiler _compiler = compiler;
    readonly Runtime _runtime = runtime;

    public void Start(string sourceCode)
    {
        _editor.Write(sourceCode);
        _editor.Save();
        _compiler.Compile();
        _runtime.Execute();
    }

    public void Stop()
    {
        _runtime.Finish();
    }
}