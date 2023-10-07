using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class Team
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public Guid AccountId { get; set; }

        public virtual ICollection<TaskAssignee> TaskAssignees { get; set; }
    }
}
