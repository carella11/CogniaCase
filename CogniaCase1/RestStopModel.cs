namespace CogniaCase1;

public class RestStopModel
{
    public int id { get; set; }
    public string parkeringstilbyderNavn { get; set; }
    public float breddegrad { get; set; }
    public float lengdegrad { get; set; }
    public object deaktivert { get; set; }
    public int versjonsnummer { get; set; }
    public string navn { get; set; }
    public string adresse { get; set; }
    public string postnummer { get; set; }
    public string poststed { get; set; }
    public DateTime aktiveringstidspunkt { get; set; }
    public Facilities facilities { get; set; }

    public class Facilities
    {
        public bool food { get; set; }
        public bool restroom { get; set; }
        public bool laundry { get; set; }
        public bool shower { get; set; }
        public bool parkingForTrucks { get; set; }
    }
}