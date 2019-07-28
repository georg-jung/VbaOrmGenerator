using System;
using System.Collections.Generic;

namespace OrmGenerator
{
    public class EntityDefinition
    {
        public EntityDefinition(string name)
        {
            Name = name;
            TableName = name;
        }

        public EntityDefinition(string entityName, string tableName)
        {
            Name = entityName;
            TableName = tableName;
        }

        public string Name { get; set; }
        public string TableName { get; set; }
        public Dictionary<string, EntityPropertyDetails> Properties { get; set; } = new Dictionary<string, EntityPropertyDetails>();
    }
}
