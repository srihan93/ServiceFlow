using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFlow.DataAccess
{
    [Table("Mtr_Status")]
    public class Status
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
    }

    [Table("Mtr_Reason")]
    public class Reason
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
    }

    [Table("Mpp_ReasonInStatus")]
    [Keyless]
    public class ReasonInStatus
    {
        [ForeignKey("StatusId")]
        public Guid StatusId { get; set; }

        public Status Status { get; set; }

        [ForeignKey("ReasonId")]
        public Guid ReasonId { get; set; }

        public Reason Reason { get; set; }
        public bool IsActive { get; set; }
    }
}