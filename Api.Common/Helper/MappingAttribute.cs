using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Common.Helper
{
    public class MappingAttribute : Attribute
    {
        public MappingAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
}
