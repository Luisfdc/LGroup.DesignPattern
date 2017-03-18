using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversion.JeitoCerto
{
    public interface IDbConnection
    {
        void Open();
        void Close();
    }
}
