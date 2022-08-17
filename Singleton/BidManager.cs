namespace Singleton;

public class BidManager
{
    private static BidManager _bidManager;
    private static object _lockObject = new();
    private BidManager() { }
    
    public static BidManager CreateAsSingleton()
    {
        lock (_lockObject)
        {
            _bidManager ??= new BidManager();
        }

        return _bidManager;
    }
    
    public void Save()
    {
        Console.WriteLine("Saved");
    }
}