using System;
using System.Collections.Generic;
using System.Text;

namespace OrmGenerator
{
    public interface ITypeMapper
    {
        string Map(string inputType);
    }
}
