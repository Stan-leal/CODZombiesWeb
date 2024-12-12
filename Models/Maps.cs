using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CODZombiesWeb.Models;

public class Map
{
    public int MapID {get; set;} 
    
    [Display(Name = "Map Name")]
    public string MapName {get; set;} = string.Empty;
    
    
    
}
