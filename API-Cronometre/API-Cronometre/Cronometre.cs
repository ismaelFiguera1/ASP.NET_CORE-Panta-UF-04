namespace API_Cronometre
{
    public class Cronometre
    {
        public int Id { get; set; }
        public bool Executant { get; set; }
        public string Name { get; set; }

        public string TempsTranscorregut { get; set; }
        public Cronometre() { }
    }
}
