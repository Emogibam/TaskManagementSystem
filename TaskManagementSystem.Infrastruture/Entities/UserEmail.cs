using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class UserEmail
    {

        [Key]
        public Guid Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public bool IsPrimary { get; set; }
        [Required]

        public bool IsEmailConfirmed { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
