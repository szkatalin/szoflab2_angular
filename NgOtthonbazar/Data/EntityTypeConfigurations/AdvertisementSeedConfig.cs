using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Otthonbazar.Data.EntityTypeConfigurations
{
    public class AdvertisementSeedConfig : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> builder)
        {
            builder.HasData(
                new Advertisement
                {
                    Id = 1,
                    CityId = 1,
                    Address = "Kiss Ernő utca",
                    ImageUrl = "/images/adv-image1.jpg",
                    AdvertisementType = AdvertisementType.House,
                    Price = 36.5m,
                    Size = 120,
                    Room = 2,
                    HalfRoom = 3,
                    BuildDate = 2011,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 2,
                    CityId = 1,
                    Address = "Diófa utca",
                    ImageUrl = "/images/adv-image2.jpg",
                    AdvertisementType = AdvertisementType.Flat,
                    Price = 44m,
                    Size = 140,
                    Room = 3,
                    HalfRoom = 2,
                    BuildDate = 2011,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 3,
                    CityId = 1,
                    Address = "Arany János utca",
                    ImageUrl = "/images/adv-image3.jpg",
                    AdvertisementType = AdvertisementType.House,
                    Price = 324.1m,
                    Size = 270,
                    Room = 4,
                    HalfRoom = 2,
                    BuildDate = 2017,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 4,
                    CityId = 1,
                    Address = "Epreskert utca",
                    ImageUrl = "/images/adv-image4.jpg",
                    AdvertisementType = AdvertisementType.House,
                    Price = 30m,
                    Size = 120,
                    Room = 2,
                    HalfRoom = 1,
                    BuildDate = 2011,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 5,
                    CityId = 2,
                    Address = "Irinyi utca",
                    ImageUrl = "/images/adv-image5.jpg",
                    AdvertisementType = AdvertisementType.House,
                    Price = 13.3m,
                    Size = 42,
                    Room = 1,
                    HalfRoom = 1,
                    BuildDate = 2006,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 6,
                    CityId = 2,
                    Address = "Magyar tudósok krt",
                    ImageUrl = "/images/adv-image6.jpg",
                    AdvertisementType = AdvertisementType.Flat,
                    Price = 56m,
                    Size = 88,
                    Room = 2,
                    HalfRoom = 2,
                    BuildDate = 2008,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 7,
                    CityId = 2,
                    Address = "Bartók Béla",
                    ImageUrl = "/images/adv-image7.jpg",
                    AdvertisementType = AdvertisementType.House,
                    Price = 43m,
                    Size = 91,
                    Room = 3,
                    HalfRoom = 2,
                    BuildDate = 2010,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 8,
                    CityId = 2,
                    Address = "Gárdonyi tér",
                    ImageUrl = "/images/adv-image8.jpg",
                    AdvertisementType = AdvertisementType.House,
                    Price = 21.5m,
                    Size = 56,
                    Room = 2,
                    HalfRoom = 1,
                    BuildDate = 2003,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 9,
                    CityId = 2,
                    Address = "Műegyetem rakpart",
                    ImageUrl = "/images/adv-image9.jpg",
                    AdvertisementType = AdvertisementType.Flat,
                    Price = 29.9m,
                    Size = 61,
                    Room = 2,
                    HalfRoom = 2,
                    BuildDate = 1999,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 10,
                    CityId = 3,
                    Address = "Teve utca",
                    ImageUrl = "/images/adv-image10.jpg",
                    AdvertisementType = AdvertisementType.Flat,
                    Price = 24.5m,
                    Size = 83,
                    Room = 2,
                    HalfRoom = 2,
                    BuildDate = 2002,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 11,
                    CityId = 3,
                    Address = "Váci út",
                    ImageUrl = "/images/adv-image11.jpg",
                    AdvertisementType = AdvertisementType.House,
                    Price = 31m,
                    Size = 78,
                    Room = 1,
                    HalfRoom = 3,
                    BuildDate = 2011,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 12,
                    CityId = 3,
                    Address = "Dagály utca",
                    ImageUrl = "/images/adv-image12.jpg",
                    AdvertisementType = AdvertisementType.BuildingPlot,
                    Price = 42m,
                    Size = 99,
                    Room = 3,
                    HalfRoom = 1,
                    BuildDate = 2012,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 13,
                    CityId = 3,
                    Address = "Visegrádi utca",
                    ImageUrl = "/images/adv-image13.jpg",
                    AdvertisementType = AdvertisementType.House,
                    Price = 28.5m,
                    Size = 58,
                    Room = 2,
                    HalfRoom = 1,
                    BuildDate = 2013,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Advertisement
                {
                    Id = 14,
                    CityId = 4,
                    Address = "Háros utca",
                    ImageUrl = "/images/adv-image14.jpg",
                    AdvertisementType = AdvertisementType.HolidayHouse,
                    Price = 47.2m,
                    Size = 114,
                    Room = 3,
                    HalfRoom = 2,
                    BuildDate = 2009,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                });
        }
    }
}
