using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
namespace BrasilAPIC_.Mappings
{
    public class BancoMapping:Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>),typeof(ResponseGenerico<>));
            CreateMap<BancoResponse,BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}