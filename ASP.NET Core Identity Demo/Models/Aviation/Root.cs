using System.Collections.Generic;

namespace ASP.NET_Core_Identity_Demo.Models.Aviation
{
    public class Root
    {
        public Pagination pagination { get; set; }
        public List<DataItem> data { get; set; }
    }
}
