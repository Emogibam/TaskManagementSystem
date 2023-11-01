using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class TaskAssignee
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid TaskId { get; set; }
        [Required]
        public Guid AssigneeId { get; set; }
        [Required]
        public Guid AccountId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("TaskId")]
        public virtual Tasks Task { get; set;}
        public virtual Team Team { get; set; }
    }
}
