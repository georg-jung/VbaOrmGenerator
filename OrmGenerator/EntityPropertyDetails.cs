using System;
using System.Collections.Generic;
using System.Text;

namespace OrmGenerator
{
    public class EntityPropertyDetails
    {
        public EntityPropertyDetails(string type)
        {
            Type = type;
        }

        public EntityPropertyDetails(string type, bool mapped) : this(type)
        {
            Mapped = mapped;
        }

        public string Type { get; set; }
        public bool Mapped { get; set; } = true;
    }
}
