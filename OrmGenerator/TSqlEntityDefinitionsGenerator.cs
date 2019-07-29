using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace OrmGenerator
{
    public class TSqlEntityDefinitionsGenerator : IEntityDefinitionsGenerator
    {
        private readonly ITypeMapper _typeMapper;
        private readonly IOptionsMonitor<TSqlEntityDefinitionsGeneratorOptions> _options;
        private static readonly string _schemaInfoQuery = @"SELECT C.TABLE_NAME, C.COLUMN_NAME, C.DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS C
INNER JOIN INFORMATION_SCHEMA.TABLES T
	ON C.TABLE_NAME = T.TABLE_NAME
WHERE T.TABLE_SCHEMA <> 'sys'";
        private static readonly string _schemaInfoQueryJustTables = $@"{_schemaInfoQuery} AND T.TABLE_TYPE='BASE TABLE'";

        public string? ConnectionString { get; set; }

        public TSqlEntityDefinitionsGenerator(ITypeMapper typeMapper, IOptionsMonitor<TSqlEntityDefinitionsGeneratorOptions> options)
        {
            _typeMapper = typeMapper;
            _options = options;
        }

        public async Task<IEnumerable<EntityDefinition>> GenerateEntityDefinitions()
        {
            var opt = _options.CurrentValue;
            using var con = new SqlConnection(ConnectionString ?? throw new InvalidOperationException($"The connection string given as option can not be null."));
            var query = opt.JustTables ? _schemaInfoQueryJustTables : _schemaInfoQuery;
            var schemaInfos = await con.QueryAsync<SchemaInfo>(query).ConfigureAwait(false);
            return ExtractEntityDefinitions(schemaInfos);
        }

        private IEnumerable<EntityDefinition> ExtractEntityDefinitions(IEnumerable<SchemaInfo> schemaInfos)
        {
            var groupedByTable = schemaInfos.GroupBy(si => si.Table_Name);
            foreach (var tableGroup in groupedByTable)
            {
                var entityDef = new EntityDefinition(tableGroup.Key);
                foreach (var schemaInfo in tableGroup)
                {
                    var schemaColumn = schemaInfo.Column_Name ?? throw new InvalidCastException($"Schema table has null COLUMN_NAME for table {schemaInfo.Table_Name}. This should never happen when connected to a functional T-SQL-Server.");
                    var schemaType = schemaInfo.Data_Type ?? throw new InvalidCastException($"Schema table has null DATA_TYPE for column {schemaInfo.Table_Name}.{schemaInfo.Column_Name}. This should never happen when connected to a functional T-SQL-Server.");
                    var mappedType = _typeMapper.Map(schemaType);
                    var propDetails = new EntityPropertyDetails(mappedType);
                    entityDef.Properties.Add(schemaColumn, propDetails);
                }
                yield return entityDef;
            }
        }

        private class SchemaInfo
        {
            public string? Table_Name { get; set; }
            public string? Column_Name { get; set; }
            public string? Data_Type { get; set; }
        }
    }
}
