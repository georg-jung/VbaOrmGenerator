using System;
using System.Collections.Generic;
using System.Text;

namespace OrmGenerator
{
    public class CodeFile : ICodeFile
    {
        public CodeFile(string relativePath, string content)
        {
            RelativePath = relativePath;
            Content = content;
        }

        public string RelativePath { get; }

        public string Content { get; }
    }
}
