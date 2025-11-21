using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.models.entities;

public class Amenity
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<PlaceAmenity> PlaceAmenities { get; set; }

    
}