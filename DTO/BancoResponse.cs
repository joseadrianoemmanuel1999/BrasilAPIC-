using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrasilAPIC_.DTO
{
    public class BancoResponse
    {
          
        public string? Ispb { get; set; }
        public string? NomeAbreviado { get; set; }
        public int? codigo { get; set; }
        public string? NomeCompleto { get; set; }
    }
}