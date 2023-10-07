using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class TaskAssignee
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid AssigneeId { get; set; }
        public Guid AccountId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Tasks Task { get; set;}
        public virtual Team Team { get; set; }
    }
}
