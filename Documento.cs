

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






public class Documento
{
    public string Codice { get; set; }
    public string Titolo { get; }

    public int Anno { get; set; }
    public string Settore { get; }
    public string Stato { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; }

    public Documento(string codice, string titolo, int anno, string settore, string stato, string scaffale, string autore)
    {
        this.Codice = codice;
        this.Titolo = titolo;
        this.Anno = anno;
        this.Settore = settore;
        this.Stato = stato;
        this.Scaffale = scaffale;
        this.Autore = autore;
    }
    public override string ToString()
    {
        return  Titolo + " Codice : " + Codice;
    }
}

