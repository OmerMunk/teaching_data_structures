namespace data_structures;

public  class Terorrists
{
    static Dictionary<string, Location> terorrists  = new Dictionary<string, Location>();

    public void anaAref()
    {
        terorrists.Add("A", new Location(0, 0));
        terorrists["B"] = new Location(0, 0);
    }

}


public class Location
{
    public int x { get; set; }
    public int y { get; set; }

    public Location(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}