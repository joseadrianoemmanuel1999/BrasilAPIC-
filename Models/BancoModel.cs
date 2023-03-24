using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrasilAPIC_.Models
{
    public class BancoModel
    {
         [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")]
        public string? NomeAbreviado { get; set; }

        [JsonPropertyName("code")]
        public int? codigo { get; set; }

        [JsonPropertyName("fullName")]
        public string? NomeCompleto { get; set; }
    }
}