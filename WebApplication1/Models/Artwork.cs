using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Artwork
{
    public int ArtworkId { get; set; }
    [Required] public double? Price { get; set; }
    [Required] public DateOnly CreationDate { get; set; }
    [Required] public ArtType ArtType { get; set; }
}