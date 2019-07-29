using System;
using System.Collections.Generic;
using System.Text;

namespace OrmGenerator.Vba.T4
{
    partial class ModelClass
    {
        public ModelClass(EntityDefinition entity)
        {
            Entity = entity;
        }

        public EntityDefinition Entity { get; }
    }
}
