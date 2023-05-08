using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrasilAPIC_.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>>BuscarTodos();
        Task<ResponseGenerico<BancoResponse>>BuscarBanco(string condigBanco);
        
    }
}