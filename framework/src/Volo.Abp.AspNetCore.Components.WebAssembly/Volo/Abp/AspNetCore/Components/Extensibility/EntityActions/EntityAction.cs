﻿using System;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Components.Extensibility.EntityActions
{
    public class EntityAction:IEquatable<EntityAction>
    {
        public string Text { get; set; }
        public Func<object, Task> Clicked { get; set; }
        public string RequiredPolicy { get; set; }
        public Func<object, string> ConfirmationMessage { get; set; }
        public bool Primary { get; set; }
        public bool Equals(EntityAction other)
        {
            return string.Equals(Text, other?.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
