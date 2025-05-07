namespace Singleton;

public class DbConnection
{
    private static DbConnection? Connection;
    public string Configuration { get; private set; }

    protected DbConnection(string configuration)
    {
        Configuration = configuration;
    }

    public static DbConnection? GetConnectionInstance(string dbServer)
    {
        return Connection ??= new DbConnection(dbServer);
    }
}