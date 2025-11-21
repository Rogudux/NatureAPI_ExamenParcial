using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.models.entities;

public class Place
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    
    [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90.")]
    public double Latitude { get; set; }
    
    [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180.")]
    public double Longitude { get; set; }
    
    public int ElevationMeters { get; set; }
    public bool Accessible { get; set; }
    public double EntryFee { get; set; }
    public string OpeningHours { get; set; }
    public DateTime CreatedAt { get; set; }

    public List<Trail> Trails { get; set; }
    public List<Photo> Photos { get; set; }
    public List<Review> Reviews { get; set; }
    
    public ICollection<PlaceAmenity> PlaceAmenities { get; set; } = new List<PlaceAmenity>();

}
