

//Si vuole progettare un sistema per la gestione di una biblioteca dove il bibliotecario può verificare i dati dei clienti registrati
//cognome,
//nome,
//email,
//recapito telefonico,
//Il bibliotecario può effettuare dei prestiti ai suoi clienti registrati, attraverso il sistema, sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//Il bibliotecario deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un cliente.


using System.Runtime.CompilerServices;

public class Biblioteca
{
    string[] nomi = { "Gloria", "Giulio", "Federico", "Alessandro" };
    string[] cognomi = { "Rossi", "Verdi", "Bianchi", "Gialli" };
    string[] email = { "gloria@gmail.com", "giulio@gmail.com", "federico@gmail.com", "alessandro@gmail.com" };
    string[] telefono = { "343252525", "324235235", "53264346326", "3665466246" };
    string[] codice = { "45346634643", "6346346436", "255235135325", "25325252532" };
    string[] codiceISBN = { "3463463463463", "2346366363463", "64663642464256", "3463462462624" };
    string[] titoloDVD = { "Cuori solitari", "Il signore degli anelli", "Titanic", "Spiderman" };
    string[] titoloLibri = { "Guerra e Pace", "Il codice DaVinci", "Il grande libro degli insetti", "Dinosauri" };
    int[] anno = { 2007, 1987, 2000, 1990 };
    string[] settore = { "Cucina", "Economia", "Politica", "Commedia" };
    string[] stato = { "In prestito", "Disponibile", "In prestito", "Disponibile" };
    string[] scaffale = { "B4", "C5", "D7", "I9" };
    string[] nomeautore = { "Topolino", "Paperino", "Minnie", "Spiderman" };
    string[] cognomeautore = { "Topolini", "Paperini", "Topina", "Ragno" };

    int[] durata = { 120, 150, 80, 115 };
    int[] pagine = { 500, 300, 280, 315 };


    public List<Utente> utenti = new List<Utente>();
    public List<Documento> documenti = new List<Documento>();
    public List<Prestito> prestiti = new List<Prestito>();


    public Biblioteca()
    {
        users = new Utente[4];
        dvds = new Dvd[4];
        libri = new Libro[4];
        prestitiDVD = new Prestito[4];
        prestitiLibri = new Prestito[4];

        for (int i = 0; i < 4; i++)
        {
            users[i] = new Utente(nomi[i], cognomi[i], email[i], telefono[i]);
            utenti.Add(users[i]);
            dvds[i] = new Dvd(codice[i], titoloDVD[i], anno[i], settore[i], stato[i], scaffale[i], nomeautore[i], cognomeautore[i], durata[i]);
            libri[i] = new Libro(codiceISBN[i], titoloLibri[i], anno[i], settore[i], stato[i], scaffale[i], nomeautore[i], cognomeautore[i], pagine[i]);

            documenti.Add(dvds[i]);
            documenti.Add(libri[i]);
            prestitiDVD[i] = new Prestito("11 maggio 2022", "11 giugno 2022", dvds[i], users[i]);
            prestitiLibri[i] = new Prestito("15 maggio 2022", "15 giugno 2022", libri[i], users[i]);
            prestiti.Add(prestitiDVD[i]);
            prestiti.Add(prestitiLibri[i]);

        }

    }
    public Utente[] users;
    public Dvd[] dvds;
    public Libro[] libri;
    public Prestito[] prestitiDVD;
    public Prestito[] prestitiLibri;

    public void Search(int ricerca, string userSearch)
    {
        foreach (Documento item in documenti)
        {
            if (ricerca == 1)
            {
                if (item.Codice == userSearch)
                    Console.WriteLine("Trovato {1}: {0} ", item, item.GetType().ToString());
            }
            else if(ricerca == 2)
            {
                if (item.Titolo == userSearch)
                    Console.WriteLine("Trovato {1}: {0} ", item, item.GetType().ToString());
            }
        }
    }

    public void Prestiti(string inizioPrestito, string finePrestito, string titoloRicerca, Documento documentoPrestito, bool presente)
    {
        bool nonTrovato = false;
        foreach (Documento item in documenti)
        {


            if (item.Titolo == titoloRicerca)
            {
                Console.WriteLine("Trovato {1}: {0} ", item, item.GetType().ToString());
                documentoPrestito = item;
                nonTrovato = true;

                if (item.Stato == "In prestito")
                {
                    Console.Clear();
                    Console.WriteLine("Il documento non è al momento disponibile!");
                    presente = false;
                }
            }
        }
        //se documento non trovato
        if (nonTrovato == false)
        {
            Console.Clear();
            Console.WriteLine("Documento non trovato!");
        }
        //se presente in biblioteca
        if (presente == true)
        {
            Console.WriteLine("Inserisci il nome di chi devo effettuare il prestito");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome");
            string cognome = Console.ReadLine();

            foreach (Utente item in utenti)
            {
                if (item.Nome == nome && item.Cognome == cognome)
                {

                    Utente utente = item;
                    Prestito prestito = new Prestito(inizioPrestito, finePrestito, documentoPrestito, utente);
                    Console.WriteLine("Inserito {1}: {0} ", prestito, prestito.GetType().ToString());
                    prestiti.Add(prestito);
                }
            }

        }

    }

    public void SearchPrestito(string nome, string cognome)
    {
        foreach (Prestito item in prestiti)
        {
            if (item.Utente.Nome == nome && item.Utente.Cognome == cognome)
            {
                Console.WriteLine("Trovato {1}: {0} ", item, item.GetType().ToString());
            }

        }
    }
}