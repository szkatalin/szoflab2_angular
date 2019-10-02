using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otthonbazar.Data
{
    public class City
    {
        public int Id { get; set; }
        [Required, StringLength(4, MinimumLength = 4)]
        public string Zip { get; set; }
        [Required]
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Advertisement> Advertisements { get; set; }
    }
}
