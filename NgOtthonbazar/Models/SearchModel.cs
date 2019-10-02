namespace Otthonbazar.Models
{
    public class SearchModel
    {
        public int? CityId { get; set; }
        public string CityName { get; set; }

        public decimal? PriceMin { get; set; }
        public decimal? PriceMax { get; set; }

        public int? SizeMin { get; set; }
        public int? SizeMax { get; set; }

        public int? RoomMin { get; set; }
        public int? RoomMax { get; set; }

        public int? Page { get; set; }
        public int? PageSize { get; set; }
    }
}
