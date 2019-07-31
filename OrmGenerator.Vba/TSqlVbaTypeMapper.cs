using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrmGenerator.Vba
{
    public class TSqlVbaTypeMapper : ITypeMapper
    {
        public string Map(string inputType)
        {
            return inputType.ToLowerInvariant() switch
            {
                "datetime" => "Date",
                "datetime2" => "Date",
                "time" => "Date",
                "smalldatetime" => "Date",
                "bigint" => Use64bitTypes ? "LongLong" : "Long",
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
                _ => VariantOnUnknownType ? "Variant" : throw new ArgumentException($"There is no VBA type mapping for T-SQL type {inputType}")
            };
        }

        public bool VariantOnUnknownType { get; set; } = true;

        public bool Use64bitTypes { get; set; } = true;
    }
}
