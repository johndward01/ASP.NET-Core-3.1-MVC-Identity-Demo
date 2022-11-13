namespace ASP.NET_Core_Identity_Demo.Models.Aviation
{
    public class DataItem
    {
        public string flight_date { get; set; }
        public string flight_status { get; set; }
        public Departure departure { get; set; }
        public Arrival arrival { get; set; }
        public Airline airline { get; set; }
        public Flight flight { get; set; }
        public string aircraft { get; set; }
        public string live { get; set; }
    }














}
