namespace AspNetCore6WebAPI.Cityinfo.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int NumberOfPointOfInterest
        {
            get
            {
                return pointOfInterest.Count;
            }
        }

        public ICollection<PointOfInterestDto> pointOfInterest { get; set; } = new List<PointOfInterestDto>();
    }
}
