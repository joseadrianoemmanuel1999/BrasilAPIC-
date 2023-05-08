using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BrasilAPIC_.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        public readonly IBancoService _BancoService;

        public BancoController(IBancoService bancoService)
        {
            _BancoService = bancoService;
        }
        [HttpGet("buscar/todos")]

        public async Task<IActionResult>BuscarTodos()
        {
            var response = await _BancoService.BuscarTodos();
            if(response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp,response.ErroRetorno);
            }
        }
          [HttpGet("busca/{codigoBanco}")]
        public async Task<IActionResult>Buscar([RegularExpression("^[0-9]*$")] string codigoBanco)
        {
            
            var response = await _BancoService.BuscarBanco(codigoBanco);
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