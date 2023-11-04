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

        public override object Perform([CanBeNull] object obj, EntityState state, [CanBeNull] object originalValue, object parentEntity, string propertyName)
        {
            var shouldAct = (state == EntityState.Added || state == EntityState.Modified)
                && obj != null && (Guid) obj == default(Guid);

            return shouldAct ? SequentialGuid.Create() : obj;
        }
    }
}
