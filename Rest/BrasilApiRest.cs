using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
namespace BrasilAPIC_.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
             var request = new HttpRequestMessage(HttpMethod.Get,$"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");
            var response = new ResponseGenerico<BancoModel>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi= await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsByteArrayAsync();
                var objResponse = JsonSerializer.Deserialize<BancoModel>(contentResp);
                if(responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
                
            }
             
            return response  ;
        }

        public async Task<ResponseGenerico<EnderecoModel>> buscarEnderecoPorCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,$"https://brasilapi.com.br/api/cep/v1/{cep}");
            var response = new ResponseGenerico<EnderecoModel>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi= await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsByteArrayAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);
                if(responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
                
            }
             
            return response  ;
        }

        public async Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,$"https://brasilapi.com.br/api/banks/v1");
            var response = new ResponseGenerico<List<BancoModel>>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi= await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsByteArrayAsync();
                var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp);
                if(responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
                
            }
             
            return response  ;
        }
    }
}