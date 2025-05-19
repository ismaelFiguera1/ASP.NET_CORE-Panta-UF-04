using System.Diagnostics;

namespace API_Cronometre.Services
{
    public class CronometreService
    {
        public List<Cronometre> cronometres = new();
        public Dictionary<Guid, Stopwatch> valorsCronometres = new Dictionary<Guid, Stopwatch>();

        public CronometreService()
        {

            Guid id1 = Guid.NewGuid();
            Guid id2 = Guid.NewGuid();
            Guid id3 = Guid.NewGuid();


            cronometres.Add(new Cronometre(id1, false, "Temporitzador1", "00:00:00"));
            cronometres.Add(new Cronometre(id2, false, "Temporitzador2", "00:00:00"));
            cronometres.Add(new Cronometre(id3, false, "Temporitzador3", "00:00:00"));

            Stopwatch relotge = new Stopwatch();
            Stopwatch relotge1 = new Stopwatch();
            Stopwatch relotge2 = new Stopwatch();


            valorsCronometres.Add(cronometres[0].Id, relotge);
            valorsCronometres.Add(cronometres[1].Id, relotge1);
            valorsCronometres.Add(cronometres[2].Id, relotge2);

        }





        // Obtenim TOTS els conometres





        public List<Cronometre> ObtenirCronometres()
        {
            return cronometres;
        }





        // Iniciem el conometre que tingu el id





        public bool IniciarCronometre(Guid id)
        {
            bool trobat = false;
            
            foreach (Cronometre c in cronometres)
            {
                // Busco el id a la llista de cronometres 
                if (c.Id == id)
                {
                    trobat = true;
                    // Si el trobo, a les KEY del diccionari busco el id
                    if (valorsCronometres.ContainsKey(id))
                    {
                        // Creo el Stopwatch, que es el que fa la gestio del temps
                        Stopwatch reloj = valorsCronometres[id];

                        // Si el relotge no esta corrent l'inicio
                        if (!reloj.IsRunning)
                        {
                            reloj.Start();           
                            c.Executant = true;      
                        }
                    }

                    break; 
                } 
            }
            return trobat;
        }





        // Vejem l'estat del conometre buscat per id





        public Cronometre? EstatCronometre(Guid id)
        {

            // Busquem el conometre
            foreach (Cronometre c in cronometres)
            {
                if (c.Id == id)
                {
                    // Comprovem si hi ha un rellotge al diccionari
                    if (valorsCronometres.ContainsKey(id))
                    {
                        Stopwatch rellotge = valorsCronometres[id];

                        // Si el rellotge està funcionant, actualitzem el temps actual
                        if (rellotge.IsRunning)
                        {
                            TimeSpan temps = rellotge.Elapsed;
                            c.TempsTranscorregut = temps.ToString(@"hh\:mm\:ss");
                        }
                    }

                    return c; // Retornem el cronòmetre amb el seu estat actualitzat
                }
            }

            return null; // Si no s’ha trobat cap cronòmetre amb aquest ID
        }

    }
}



