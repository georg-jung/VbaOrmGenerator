using System;
using System.Collections.Generic;
using System.Text;

namespace OrmGenerator
{
    public interface ICodeFile
    {
        public string RelativePath { get; }
        public string Content { get; }
    }
}
