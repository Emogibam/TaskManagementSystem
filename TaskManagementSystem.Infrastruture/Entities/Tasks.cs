using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class Tasks
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CreatorUserId { get; set; }
        public DateTime ClosedDate { get; set; }
        public Guid AccountId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAcheived { get; set; }
        public virtual ICollection<TaskAssignee> TaskAssignees { get; set; }
    }

    public enum Status
    {
        ToDo,
        InProgress,
        Blocked,
        Review,
        Completed,
        Deferred,
        Canceled,
        OnHold,
        Rejected,
        Archived,
        InReview,
        Scheduled,
        InTesting,
        WaitingForInput,
        Reopened,
        InDesign,
        InCodeReview,
        InValidation,
        InDocumentation,
        InDeployment,
        InMaintenance
    }
}
