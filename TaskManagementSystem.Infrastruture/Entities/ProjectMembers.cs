using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class ProjectMembers
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid MemberId { get; set; }
        [Required]
        public Guid AccountId { get; set; }
        [Required]
        public Guid ProjectId { get; set; }
        [ForeignKey("ProjectId")]
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
