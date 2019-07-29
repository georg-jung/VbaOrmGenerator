using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrmGenerator
{
    public interface ICodeGenerator
    {
        IEnumerable<ICodeFile> Generate(IEnumerable<EntityDefinition> entities);
    }
}
