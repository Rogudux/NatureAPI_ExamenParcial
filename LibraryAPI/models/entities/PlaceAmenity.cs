namespace LibraryAPI.models.entities;

public class PlaceAmenity
{
    public Place Place { get; set; }
    public int PlaceId { get; set; }

    public Amenity Amenity { get; set; }
    public int AmenityId { get; set; }
    
    
    
}