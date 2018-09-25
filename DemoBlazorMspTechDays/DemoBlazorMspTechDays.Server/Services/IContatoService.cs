using DemoBlazorMspTechDays.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorMspTechDays.Server.Services
{
    public interface IContatoService
    {
        Contato Obter(long id);
        IEnumerable<Contato> ListarTodos();
        IEnumerable<Contato> Buscar(string texto);
        Contato Incluir(Contato contato);
        void Atualizar(Contato contato);
        void Excluir(long id);
    }
}
