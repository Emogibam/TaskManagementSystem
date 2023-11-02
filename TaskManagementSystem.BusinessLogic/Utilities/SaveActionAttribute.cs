using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.BusinessLogic.Utilities
{
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class SaveActionAttribute : Attribute
    {
        public abstract bool CanPerform(Type type);

        public abstract bool Perform([CanBeNull] object value, EntityState state,
            [CanBeNull] object originalValue, object parentEntity, string propertyName);
    }
}
