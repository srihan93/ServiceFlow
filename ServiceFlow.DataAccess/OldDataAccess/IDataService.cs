using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFlow.DataAccess.OldDataAccess
{
    public interface IDataService
    {
        public Guid createWorkflow(string Name, string DisplayName);
    }
}