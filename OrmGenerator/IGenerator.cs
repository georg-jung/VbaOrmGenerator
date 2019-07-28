using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrmGenerator
{
    public interface IGenerator
    {
        Task GenerateAsync(IEnumerable<EntityDefinition> entities);
    }
}
