using Recipe.NetCore.Base.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Api.Core.Entity;

namespace Api.Core.DTO
{
    public class TestTableDTO : Dto<TestTable, long>
    {
        public string Classification { get; set; }
    }
}
