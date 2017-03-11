using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCohesion.JeitoErrado
{
    public interface ICommand
    {
        void Execute(IConnection connection, string query);
    }
}
