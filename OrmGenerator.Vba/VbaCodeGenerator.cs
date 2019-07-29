using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OrmGenerator.Vba
{
    public class VbaCodeGenerator : ICodeGenerator
    {
        public IEnumerable<ICodeFile> Generate(IEnumerable<EntityDefinition> entities)
        {
            const string orm = "ORM";
            const string models = "Models";
            const string generic = "Generic";
            yield return new CodeFile(Path.Combine(orm, "IMapper.cls"), new T4.IMapper().TransformText());
            yield return new CodeFile(Path.Combine(orm, "IMappable.cls"), new T4.IMappable().TransformText());
            yield return new CodeFile(Path.Combine(orm, "OrmAdodb.cls"), new T4.OrmAdodb().TransformText());
            yield return new CodeFile(Path.Combine(generic, "Connection.bas"), new T4.Connection().TransformText());

            foreach (var entityDefinition in entities)
            {
                var model = new T4.ModelClass(entityDefinition);
                yield return new CodeFile(Path.Combine(models, $"{entityDefinition.Name}.cls"), model.TransformText());
            }
        }
    }
}
