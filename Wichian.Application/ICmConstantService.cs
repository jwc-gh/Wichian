using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wichian.Core.EMIS.CM;

namespace Wichian.Core
{
    public interface ICmConstantService
    {
        void AddItem(string code, string name, string group);
        void DeleteItem(string code);
        void UpdateItem(string code, string name, string group);

        Constant GetItem(int id);
        List<Constant> GetSet(string group);
    }
}
