using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;  

namespace BrasilAPIC_.Interfaces
{
    public interface IBrasilApi
    {
    Task<ResponseGenerico<EnderecoModel>> buscarEnderecoPorCEP(string cep);
    Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
    Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

    }
}