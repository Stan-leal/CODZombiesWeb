namespace CODZombiesWeb.Models;

public class Game
{
    public int GameID {get; set;} 
    public string Description {get; set;} = string.Empty;
}
public class MapGame
{
    public int GameID {get; set;} 
    public int MapID {get; set;} 
    public Map Map {get; set;} = default!; 
    public Game Game {get; set;} = default!; 
}