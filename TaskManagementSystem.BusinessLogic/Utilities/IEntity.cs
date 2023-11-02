using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.BusinessLogic.Utilities
{
    public interface IEntity
    {
        [Key]
        [GenerateSequentialId]
        Guid Id { get; set; }
    }
}
