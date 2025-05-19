namespace API_Cronometre
{
    public class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Persona(int identificador, string nom) {
            this.Id = identificador;
            this.Name = nom;
        }
    }
}
