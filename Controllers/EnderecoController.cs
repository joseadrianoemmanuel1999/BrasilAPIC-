using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BrasilAPIC_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }
[HttpGet("Buscar/{cep}")]
        public async Task<IActionResult> BuscarEndereco([FromRoute]string cep)
        {
            var response = await _enderecoService.buscarEndereco(cep);
            if(response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp,response.ErroRetorno);
            }
        }
    }
}