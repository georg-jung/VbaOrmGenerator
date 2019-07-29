using System;
using System.Collections.Generic;
using System.Text;

namespace OrmGenerator.Vba
{
    public class TSqlVbaTypeMapperOptions
    {
        public bool VariantOnUnknownType { get; set; } = true;
        public bool Use64bitTypes { get; set; } = true;
    }
}
