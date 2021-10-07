using ServiceFlow.Common.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFlow.DataAccess.OldDataAccess
{
    public class DataService : IDataService
    {
        private ApplicationContext _appConext;

        public DataService(ApplicationContext applicationContext)
        {
            _appConext = applicationContext;
        }

        public Guid createWorkflow(string Name, string DisplayName)
        {
            var wf = new Workflow { Name = Name, DisplayName = DisplayName, IsActive = true, Id = new Guid() };
            var workflow = _appConext.Workflow.Add(wf);
            _appConext.SaveChanges();
            return wf.Id;
        }
    }
}