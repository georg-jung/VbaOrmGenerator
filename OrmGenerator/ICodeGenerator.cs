using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrmGenerator
{
    public interface ICodeGenerator
    {
        IAsyncEnumerable<ICodeFile> GenerateAsync(IEnumerable<EntityDefinition> entities);
    }
}
