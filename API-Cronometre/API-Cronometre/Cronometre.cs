namespace API_Cronometre
{
    public class Cronometre
    {
        public Guid Id { get; set; }
        public bool Executant { get; set; }
        public string Name { get; set; }

        public string TempsTranscorregut { get; set; }

        public Cronometre(Guid id, bool executant, string nom, string temps) 
        {
            this.Id = id;
            this.Executant = executant;
            this.Name = nom;
            this.TempsTranscorregut = temps;
        }

        public Cronometre() { }

        
        
    }
}
