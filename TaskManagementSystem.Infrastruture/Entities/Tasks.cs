using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class Tasks
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        public Guid CreatorUserId { get; set; }
        public DateTime? ClosedDate { get; set; }
        [Required]
        public Guid AccountId { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
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
