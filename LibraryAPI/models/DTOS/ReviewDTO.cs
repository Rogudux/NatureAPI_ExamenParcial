namespace LibraryAPI.models.DTOS;

public class ReviewDTO
{
    public string Author { get; set; } 
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; } 
        
}