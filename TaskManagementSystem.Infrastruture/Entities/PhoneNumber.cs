using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Entities
{
    public class PhoneNumber
    {
        public Guid Id { get; set; }
        public string Ext { get; set; }
        public string Number { get; set; }
        public bool IsPrimary { get; set; }
        public Guid UserId { get; set; }
        public Guid AccountId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
