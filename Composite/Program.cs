using Composite.Components;

var rootFolder = new Folder("root");
var myFile = new Composite.Components.File("myFile.txt");
var myFolder = new Folder("myFolder");

rootFolder.Add(myFile);
rootFolder.Add(myFolder);

rootFolder.Display();