using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrmGenerator
{
    internal class FilesGenerator : IGenerator
    {
        public FilesGenerator(string targetDirectory, ICodeGenerator codeGenerator)
        {
            TargetDirectory = targetDirectory;
            CodeGenerator = codeGenerator;
        }

        public string TargetDirectory { get; }
        public ICodeGenerator CodeGenerator { get; }

        public async Task GenerateAsync(IEnumerable<EntityDefinition> entities)
        {
            await foreach (var codeFile in CodeGenerator.GenerateAsync(entities).ConfigureAwait(false))
            {
                var path = System.IO.Path.Combine(TargetDirectory, codeFile.RelativePath);
                await System.IO.File.WriteAllTextAsync(path, codeFile.Content).ConfigureAwait(false);
            }
        }
    }
}
