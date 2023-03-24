using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace BrasilAPIC_.Service
{
    public class EnderecoService : IEnderecoService
    {
       private readonly IMapper _mapper;
       private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> buscarEndereco(string cep)
        {
            var endereco = await _brasilApi.buscarEnderecoPorCEP(cep);
            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}