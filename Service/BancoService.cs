using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace BrasilAPIC_.Service
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<BancoResponse>> BuscarBanco(string condigBanco)
        { 
          var banco = await _brasilApi.BuscarBanco(condigBanco);
          return _mapper.Map<ResponseGenerico<BancoResponse>>(banco);

        }

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos()
        { 
            var bancos = await _brasilApi.BuscarTodosBancos();
            return  _mapper.Map<ResponseGenerico<List<BancoResponse>>>(bancos);
           
        }
    }
}