using AspNetCore6WebAPI.Cityinfo.Models;

namespace AspNetCore6WebAPI.Cityinfo
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore() 
        {
            //Init Dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Colombo",
                    Description = "One of the biggest population City",
                    pointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Nugegoda",
                            Description = "The Famous city"
                        },
                         new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Maharagama",
                            Description = "The Famous city of cloths"
                        }
                    }

                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Kandy",
                    Description = "One of the Beuitify City",
                    pointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Thalathuwa",
                            Description = "The Wounderfull city"
                        },
                         new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Ankelipitiya",
                            Description = "The small city"
                        }
                    }

                },
                 new CityDto()
                {
                    Id = 1,
                    Name = "Anuradhapura",
                    Description = "One of the lage City",
                    pointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Anuradhapura 1",
                            Description = "The Wounderfull city"
                        },
                         new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Anuradhapura 2",
                            Description = "The Lage city"
                        }
                    }

                }
            };


        }
        
    }
}
