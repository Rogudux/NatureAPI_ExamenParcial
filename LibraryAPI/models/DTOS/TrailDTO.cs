namespace LibraryAPI.models.DTOS;

public class TrailDTO
{
    public string Name { get; set; }
    public double DistanceKm { get; set; }
    public int EstimatedTimeMinutes { get; set; } 
    public string Difficulty { get; set; }
    public string Path { get; set; } 
    public bool IsLoop { get; set; } 
    
}