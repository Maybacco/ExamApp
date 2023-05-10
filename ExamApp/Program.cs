using ExamApp;

internal class Program
{
    private static List<Venditore> Venditori { get; set; }
    private static List<Meccanico> Meccanici { get; set; }

    private static ResponsabileVenditori ResponsabileVenditori { get; set; }
    private static CapoOfficina ResponsabileMeccanici { get; set; }

    private static void Main(string[] args)
    {
        Venditori.Add(new Venditore()
        {
            Nome = "Franco",
            Cognome = "Battiato",
            Settore = Settore.Auto,
            Stipendio = 100
        });

        Venditori.Add(new Venditore()
        {
            Nome = "Carlo",
            Cognome = "Rossi",
            Settore = Settore.Moto,
            Stipendio = 100
        });

        Venditori.Add(new Venditore()
        {
            Nome = "Luca",
            Cognome = "Montezemolo",
            Settore = Settore.Auto,
            Stipendio = 150
        });

        Meccanici.Add(new Meccanico()
        {
            Nome = "Samuele",
            Cognome = "Carletti",
            Tipologia = Tipologia.Carrozzeria,
            Stipendio = 70
        });
        Meccanici.Add(new Meccanico()
        {
            Nome = "Franca",
            Cognome = "Carletti",
            Tipologia = Tipologia.Meccanica,
            Stipendio = 70
        });

        ResponsabileVenditori = new ResponsabileVenditori()
        {
            Nome = "Steve",
            Cognome = "Jobs",
            Settore = Settore.Moto,
            Venditori = Venditori,
            Stipendio = 250
        };

        ResponsabileMeccanici = new CapoOfficina()
        {
            Nome = "Giorgio",
            Cognome = "Sallusti",
            Stipendio = 150,
            Tipologia = Tipologia.Carrozzeria
        };

        
    }
}