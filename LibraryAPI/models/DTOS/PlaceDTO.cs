using System.ComponentModel.DataAnnotations;
using LibraryAPI.models.entities;

namespace LibraryAPI.models.DTOS;

public class PlaceDTO
{
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

    public List<TrailDTO> Trails { get; set; }
    public List<PhotoDTO> Photos { get; set; }
    public List<ReviewDTO> Reviews { get; set; }

}