using System.Collections.Generic;

namespace ASP.NET_Core_Identity_Demo.Models.API_Demo
{
    public class ChuckNorris_Response
    {
        public List<string> Categories { get; set; }
        public string Created_at { get; set; }
        public string Icon_url { get; set; }
        public string Id { get; set; }
        public string Updated_at { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }

    }
}
