using Facade.Components;

var editor = new Editor();
var compiler = new Compiler();
var runtime = new Runtime();

var ideFacade = new IdeFacade(editor, compiler, runtime);

ideFacade.Start("Console.WriteLine(\\\"Hello World!\\\");");
ideFacade.Stop();