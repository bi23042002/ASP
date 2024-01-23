namespace demo_session_1.Models
{
    public class product
    {
        public int Id { get; set; }
  
        public string Name { get; set; }
        public double price { get; set; }
        public int Quarity { get; set; }
        public string photo { get; set; }
        public bool status { get; set; }
        public DateTime Created { get; set; }

        public categlory categlory { get; set; }
    }
}
