

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

Dvd dvd1 = new Dvd("DVD001", "Cuori Infranti", 1987, "Horror", "In prestito", "A3", "Pippo Rossi", 120);
Dvd dvd2 = new Dvd("DVD002", "L'amore segreto di Topolino", 2002, "Amore", "Disponibile", "B8", "Franchino Verdi", 180);
Dvd dvd3 = new Dvd("DVD003", "Corri corri Pimpa", 1999, "Sport", "Disponibile", "D7", "Pippo Rossi", 130);
Dvd dvd4 = new Dvd("DVD004", "La vita segreta di Gerri Scotti", 2010, "Inchiesta", "In prestito", "E3", "Pippo Rossi", 220);

Libro libro1 = new Libro("BOOK001", "Il codice di Giorgio", 1887, "Horror", "In prestito", "A3", "Pippo Rossi", 1200);
Libro libro2 = new Libro("BOOK002", "L'amore e la vita delle tarantole", 2022, "Naturalistico", "Disponibile", "B8", "Franchino Verdi", 300);
Libro libro3 = new Libro("BOOK003", "Guerra e basta", 1899, "Amore", "In prestito", "D7", "Pippo Rossi", 150);
Libro libro4 = new Libro("BOOK004", "La vita è", 2010, "Inchiesta", "Disponibile", "E3", "Pippo Gialli", 700);

Utente gloria = new Utente("Gloria", "Gherardi", "laglo@yahoo.it", 3456578894);


Console.WriteLine("Premi 1 per eseguire una ricerca");
Console.WriteLine("Premi 2 per effettuare un prestito");
Console.WriteLine("Premi 3 per cercare un prestito");

int sceltaUser = Convert.ToInt32(Console.ReadLine());
if (sceltaUser == 1)
{
    Console.WriteLine("Premi 1 per cercare per codice");
    Console.WriteLine("Premi 2 per cercare per titolo");
    sceltaUser = Convert.ToInt32(Console.ReadLine());
    if (sceltaUser == 1)
    {
        Console.WriteLine("Inserisci il codice");
        sceltaUser = Convert.ToInt32(Console.ReadLine());

    }
    else if (sceltaUser == 2)
    {
        Console.Clear();
        Console.WriteLine("Inserisci il titolo");
        sceltaUser = Convert.ToInt32(Console.ReadLine());

    }
}
else if (sceltaUser == 2)
{
    Console.Clear();
    Console.WriteLine("Inserisci periodo da cui parte il prestito");
    string inizioPrestito = Console.ReadLine();
    Console.WriteLine("Inserisci periodo in cui finisce il prestito");
    string finePrestito = Console.ReadLine();
    Console.WriteLine("DVD o LIBRO?");
    string scelta = Console.ReadLine();
    Console.WriteLine("Titolo del documento da prenotare?");
    string documento = Console.ReadLine();
    if(scelta == "DVD")
    {

    } else
    {

    }


}
else if (sceltaUser == 3)
{
    Console.Clear();
    Console.WriteLine("Inserisci il nome di chi devo cercare il prestito");
    string nome = Console.ReadLine();
    Console.WriteLine("Inserisci il cognome di chi devo cercare il prestito");
    string cognome = Console.ReadLine();
}
else
{
    Console.WriteLine("Scelta errata");

}

public class Utente
{
        public string Nome { get; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public uint Telefono { get; set; }

    public Utente(string nome, string cognome, string email, uint telefono)
    {
        this.Nome = nome;   
        this.Cognome = cognome; 
        this.Email = email;
        this.Telefono = telefono;
    }
}

public class Prestito
{
    public string PrestitoDal { get; }
    public string PrestitoAl { get; }

    public int Documento { get; set; }

    public Prestito(string prestitoDal, string prestitoAl, int documento)
    {
        this.PrestitoDal = prestitoDal;
        this.PrestitoAl = prestitoAl;
        this.Documento = documento;
    }
}

public class Documento
{
    public string Codice { get; }
    public string Titolo { get; }

    public int Anno { get; set; }
    public string Settore { get; }
    public string Stato { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; }

    public Documento(string codice, string titolo, int anno, string settore, string stato, string scaffale, string autore)
    {
        Codice = codice;
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Stato = stato;
        Scaffale = scaffale;
        Autore = autore;
    }
}

public class Libro : Documento
{
    public int Pagine { get; }

    public Libro(string codice, string titolo, int anno, string settore, string stato, string scaffale, string autore, int pagine) :base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        Pagine = pagine;
    }
}
public class Dvd : Documento
{
    public int Durata { get; }

    public Dvd(string codice, string titolo, int anno, string settore, string stato, string scaffale, string autore, int durata) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        Durata = durata;
    }
}

