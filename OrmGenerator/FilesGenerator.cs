using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OrmGenerator
{
    public class FilesGenerator : IGenerator
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
            foreach (var codeFile in CodeGenerator.Generate(entities))
            {
                var path = Path.Combine(TargetDirectory, codeFile.RelativePath);
                var dir = Path.GetDirectoryName(path);
                Directory.CreateDirectory(dir);
                await File.WriteAllTextAsync(path, codeFile.Content).ConfigureAwait(false);
            }
        }
    }
}
