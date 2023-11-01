using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class PhoneNumber
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Ext { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public bool IsPrimary { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid AccountId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
