using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class ProjectMembers
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Guid AccountId { get; set; }
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public MemberType MemberType { get; set; }
    }

    public enum MemberType
    {
        Task,
        Team,
        SingleAppUser
    }
}
