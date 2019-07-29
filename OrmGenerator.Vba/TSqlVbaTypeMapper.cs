using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrmGenerator.Vba
{
    public class TSqlVbaTypeMapper : ITypeMapper
    {
        private readonly IOptionsMonitor<TSqlVbaTypeMapperOptions> _options;

        public TSqlVbaTypeMapper(IOptionsMonitor<TSqlVbaTypeMapperOptions> options)
        {
            _options = options;
        }

        public string Map(string inputType)
        {
            var opt = _options.CurrentValue;
            return inputType.ToLowerInvariant() switch
            {
                "datetime" => "Date",
                "datetime2" => "Date",
                "time" => "Date",
                "smalldatetime" => "Date",
                "bigint" => opt.Use64bitTypes ? "LongLong" : "Long",
                "int" => "Long",
                "smallint" => "Integer",
                "tinyint" => "Byte",
                "bit" => "Boolean",
                "binary" => "Byte[]",
                "image" => "Byte[]",
                "rowversion" => "Byte[]",
                "timestamp" => "Byte[]",
                "varbinary" => "Byte[]",
                "numeric" => "Decimal",
                "decimal" => "Decimal",
                "float" => "Double",
                "real" => "Single",
                "smallmoney" => "Currency",
                "money" => "Currency",
                "uniqueidentifier" => "String",
                "nvarchar" => "String",
                "varchar" => "String",
                "ntext" => "String",
                "char" => "String",
                "nchar" => "String",
                "text" => "String",
                _ => opt.VariantOnUnknownType ? "Variant" : throw new ArgumentException($"There is no VBA type mapping for T-SQL type {inputType}")
            };
        }
    }
}
