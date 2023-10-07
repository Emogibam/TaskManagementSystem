using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class UserEmail
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsEmailConfirmed { get; set;}
        public Guid UserId { get; set; }
        public Guid AccountId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
