using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
 using System.Dynamic;

namespace BrasilAPIC_.DTO
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp {get;set;}
        public T? DadosRetorno {get;set;}
        public ExpandoObject? ErroRetorno {get;set;}
        
    }
}