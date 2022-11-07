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


Biblioteca biblioteca = new Biblioteca();


//inizio programma scelta utente
Console.WriteLine("Premi 1 per eseguire una ricerca");
Console.WriteLine("Premi 2 per effettuare un prestito");
Console.WriteLine("Premi 3 per cercare un prestito");
Console.WriteLine("Premi 4 per aggiungere un utente");


int sceltaUser = Convert.ToInt32(Console.ReadLine());
if (sceltaUser == 1)
{

    Console.WriteLine("Premi 1 per cercare per codice");
    Console.WriteLine("Premi 2 per cercare per titolo");
    sceltaUser = Convert.ToInt32(Console.ReadLine());
    if (sceltaUser == 1)
    {
        Console.WriteLine("Inserisci il codice");
        string codiceRicerca = Console.ReadLine();

        biblioteca.Search(sceltaUser, codiceRicerca);
    }
    else if (sceltaUser == 2)
    {
        Console.Clear();
        Console.WriteLine("Inserisci il titolo");
        string titoloRicerca = Console.ReadLine();
        biblioteca.Search(sceltaUser, titoloRicerca);
    }
    else
    {
        Console.WriteLine("Errore ricerca");
    }
}
else if (sceltaUser == 2)
{
    Console.Clear();
    Console.WriteLine("Inserisci periodo da cui parte il prestito");
    string inizioPrestito = Console.ReadLine();
    Console.WriteLine("Inserisci periodo in cui finisce il prestito");
    string finePrestito = Console.ReadLine();
    Console.WriteLine("Titolo del documento da prenotare?");
    string titoloRicerca = Console.ReadLine();
    Documento documentoPrestito = new Documento("", "", 0, "", "", "", "", "");
    bool presente = true;

    biblioteca.Prestiti(inizioPrestito, finePrestito, titoloRicerca,  documentoPrestito,  presente);
}
else if (sceltaUser == 3)
{
    Console.Clear();
    Console.WriteLine("Inserisci il nome di chi devo cercare il prestito");
    string nome = Console.ReadLine();
    Console.WriteLine("Inserisci il cognome di chi devo cercare il prestito");
    string cognome = Console.ReadLine();
    biblioteca.SearchPrestito(nome, cognome);
}
else if (sceltaUser == 4)
{
    Console.Clear();
    Console.WriteLine("Inserisci il nome");
    string nome = Console.ReadLine();
    Console.WriteLine("Inserisci il cognome");
    string cognome = Console.ReadLine();
    Console.WriteLine("Inserisci la mail");
    string email = Console.ReadLine();
    Console.WriteLine("Inserisci il telefono");
    string telefono = Console.ReadLine();

    Utente nuovo = new Utente(nome, cognome, email, telefono);

    Console.WriteLine("{0}", nuovo, nuovo.GetType().ToString());
}
else
{
    Console.WriteLine("Scelta errata");
}
