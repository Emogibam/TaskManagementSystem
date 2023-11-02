using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.BusinessLogic.Utilities
{
    public class GenerateSequentialIdAttribute : SaveActionAttribute
    {
        public override bool CanPerform(Type type)
        {
            return type == typeof(Guid);
        }

        public override bool Perform([CanBeNull] object value, EntityState state, [CanBeNull] object originalValue, object parentEntity, string propertyName)
        {

        }
    }
}
