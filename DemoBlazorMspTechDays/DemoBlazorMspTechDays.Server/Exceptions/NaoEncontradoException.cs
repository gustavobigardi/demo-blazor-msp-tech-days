using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorMspTechDays.Server.Exceptions
{
    public class NaoEncontradoException : Exception
    {
        public NaoEncontradoException(string mensagem) : base(mensagem)
        { }
    }
}
