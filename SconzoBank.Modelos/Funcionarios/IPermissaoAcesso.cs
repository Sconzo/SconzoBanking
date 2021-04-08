using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    public interface IPermissaoAcesso
    {
        bool AutenticarFuncionario(string senha);
    }
}
