using System;

namespace Api.Database.Base.Abstract
{
    public class DtoBase
    {
        public bool HasErrors { get; set; }

        public Exception Error { get; set; }
    }
}
