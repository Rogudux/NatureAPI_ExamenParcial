namespace LibraryAPI.models.entities;

public class Photo
{
    public int Id { get; set; }
    
    public int PlaceId { get; set; }
    public Place Place { get; set; }
    
    public string URL { get; set; }
}