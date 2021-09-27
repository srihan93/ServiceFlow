using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

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

    [Table("Mtr_Workflow")]
    public class Workflow
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
    }

    [Table("Mtr_Attribute")]
    public class Attribute
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public string Type { get; set; }

        public bool IsRequired { get; set; }
        public bool IsActive { get; set; }
    }

    [Table("Mtr_WorkflowConfiguration")]
    [Keyless]
    public class WorkflowConfiguration
    {
        [ForeignKey("WorkflowId")]
        public Guid WorkflowId { get; set; }

        public Workflow Workflow { get; set; }

        [ForeignKey("CurrentStatusId")]
        public Guid CurrentStatusId { get; set; }

        public Status CurrentStatus { get; set; }

        [ForeignKey("NextStatusId")]
        public Guid NextStatusId { get; set; }

        public Status NextStatus { get; set; }

        public bool IsStart { get; set; }
        public bool IsEnd { get; set; }
    }
}