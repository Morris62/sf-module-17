using Singleton;

Application app = new Application();
app.Launch("192.168.1.1");
Console.WriteLine(app.DbConnection?.Configuration);

app.DbConnection = DbConnection.GetConnectionInstance("192.168.2.1");
Console.WriteLine(app.DbConnection?.Configuration);