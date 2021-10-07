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
            _appConext.Workflow.Add(wf);
            return wf.Id;
        }

        public Guid createStatus(string Name, string DisplayName)
        {
            var status = new Status { Name = Name, DisplayName = DisplayName, IsActive = true, Id = new Guid() };
            _appConext.Status.Add(status);
            var rs = new Reason { Name = Name, DisplayName = DisplayName, IsActive = true, Id = new Guid() };
            _appConext.Reason.Add(rs);
            _appConext.SaveChanges();
            return status.Id;
        }

        public Guid createReason(string Name, string DisplayName, Guid statusId)
        {
            try
            {
                var status = _appConext.Status.Where(x => x.Id == statusId).FirstOrDefault();
                if (status != null)
                {
                    var reason = new Reason { Name = Name, DisplayName = DisplayName, IsActive = true, Id = new Guid() };
                    _appConext.Reason.Add(reason);
                    var reasonInStatus = new ReasonInStatus { StatusId = statusId, ReasonId = reason.Id, IsActive = true };
                    _appConext.ReasonInStatus.Add(reasonInStatus);
                    _appConext.SaveChanges();
                    return reason.Id;
                }
                else
                {
                    throw new Exception("status not available");
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}