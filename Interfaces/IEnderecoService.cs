using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BrasilAPIC_.Interfaces
{
    public interface IEnderecoService
    {
         Task<ResponseGenerico<EnderecoResponse>> buscarEndereco(string cep);
    }
}