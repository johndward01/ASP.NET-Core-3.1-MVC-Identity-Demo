using System.Collections.Generic;

namespace ASP.NET_Core_Identity_Demo.GiphyAPI
{
    public class Root
    {
        public List<DataItem> data { get; set; }
        public Pagination pagination { get; set; }
        public Meta meta { get; set; }
    }

}





