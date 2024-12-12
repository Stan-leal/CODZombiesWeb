using Microsoft.EntityFrameworkCore;

namespace CODZombiesWeb.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Maps.Any())
        {
            return;
        }

        
    List<Map> maps = new List<Map>
{
        new Map { MapName = "Nacht der Untoten" },
        new Map { MapName = "Verrückt" },
        new Map { MapName = "Shi No Numa" },
        new Map { MapName = "Der Riese" },
        new Map { MapName = "Kino der Toten" },
        new Map { MapName = "Five" },
        new Map { MapName = "Ascension" },
        new Map { MapName = "Call of the Dead" },
        new Map { MapName = "Shangri-La" },
        new Map { MapName = "Moon" },
        new Map { MapName = "TranZit" },
        new Map { MapName = "Nuketown Zombies" },
        new Map { MapName = "Die Rise" },
        new Map { MapName = "Buried" },
        new Map { MapName = "Origins" },
        new Map { MapName = "Shadows of Evil" },
        new Map { MapName = "The Giant" },
        new Map { MapName = "Der Eisendrache" },
        new Map { MapName = "Zetsubou no Shima" },
        new Map { MapName = "Gorod Krovi" },
        new Map { MapName = "Revelations" },
        new Map { MapName = "Blood of the Dead" },
        new Map { MapName = "Voyage of Despair" },
        new Map { MapName = "IX" },
        new Map { MapName = "Classified" },
        new Map { MapName = "Dead of the Night" },
        new Map { MapName = "Ancient Evil" },
        new Map { MapName = "Alpha Omega" },
        new Map { MapName = "Tag der Toten" }
};
context.AddRange(maps);

List<Game> games = new List<Game>
{
    new Game { Description = "Call of Duty: World at War" },
    new Game { Description = "Call of Duty: Black Ops" },
    new Game { Description = "Call of Duty: Black Ops II" },
    new Game { Description = "Call of Duty: Black Ops III" },
    new Game { Description = "Call of Duty: Black Ops 4" }
};
context.AddRange(games);
context.SaveChanges();

List<MapGame> mapGames = new List<MapGame>
        {
            // Call of Duty: World at War
            new MapGame { GameID = games[0].GameID, MapID = maps[0].MapID },
            new MapGame { GameID = games[0].GameID, MapID = maps[1].MapID },
            new MapGame { GameID = games[0].GameID, MapID = maps[2].MapID },
            new MapGame { GameID = games[0].GameID, MapID = maps[3].MapID },

            // Call of Duty: Black Ops
            new MapGame { GameID = games[1].GameID, MapID = maps[4].MapID },
            new MapGame { GameID = games[1].GameID, MapID = maps[5].MapID },
            new MapGame { GameID = games[1].GameID, MapID = maps[6].MapID },
            new MapGame { GameID = games[1].GameID, MapID = maps[7].MapID },
            new MapGame { GameID = games[1].GameID, MapID = maps[8].MapID },
            new MapGame { GameID = games[1].GameID, MapID = maps[9].MapID },

            // Call of Duty: Black Ops II
            new MapGame { GameID = games[2].GameID, MapID = maps[10].MapID },
            new MapGame { GameID = games[2].GameID, MapID = maps[11].MapID },
            new MapGame { GameID = games[2].GameID, MapID = maps[12].MapID },
            new MapGame { GameID = games[2].GameID, MapID = maps[13].MapID },
            new MapGame { GameID = games[2].GameID, MapID = maps[14].MapID },

            // Call of Duty: Black Ops III
            new MapGame { GameID = games[3].GameID, MapID = maps[15].MapID },
            new MapGame { GameID = games[3].GameID, MapID = maps[16].MapID },
            new MapGame { GameID = games[3].GameID, MapID = maps[17].MapID },
            new MapGame { GameID = games[3].GameID, MapID = maps[18].MapID },
            new MapGame { GameID = games[3].GameID, MapID = maps[19].MapID },
            new MapGame { GameID = games[3].GameID, MapID = maps[20].MapID },

            // Call of Duty: Black Ops 4
            new MapGame { GameID = games[4].GameID, MapID = maps[21].MapID },
            new MapGame { GameID = games[4].GameID, MapID = maps[22].MapID },
            new MapGame { GameID = games[4].GameID, MapID = maps[23].MapID },
            new MapGame { GameID = games[4].GameID, MapID = maps[24].MapID },
            new MapGame { GameID = games[4].GameID, MapID = maps[25].MapID },
            new MapGame { GameID = games[4].GameID, MapID = maps[26].MapID },
            new MapGame { GameID = games[4].GameID, MapID = maps[27].MapID },
            new MapGame { GameID = games[4].GameID, MapID = maps[28].MapID }
        };
        context.AddRange(mapGames);
        context.SaveChanges();
    }
}