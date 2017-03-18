using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Contracts
{
    public interface IDbConnection
    {
        void Open();
        void Close();
    }
}
