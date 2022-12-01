using Netflix;

var serietv1 = new SerieTV("Stranger Things", 34, 4, new string[] { "Horror", "Thriller" }, 3);
var serietv2 = new SerieTV("Squid Game", 9, 1, new string[] { "Splatter", "Thriller", "Distopico"}, 1);
var serietv3 = new SerieTV("Black Mirror", 22, 5, new string[] { "Distopico", "Thriller", "Fantascienza","Drammatico"}, 3);

List<SerieTV> ListaSerieTV = new List<SerieTV>() {serietv1, serietv2, serietv3};

foreach (var serieTV in ListaSerieTV)
    {
    serieTV.StampaSerieTv();
    }

var film1 = new Film("Avatar", "J.Cameron", 160, new string[] { "Thriller","Fantasy" });
var film2 = new Film("Your Name", "M.Shinkai", 107, new string[] { "Thriller","Animazione"});
var film3 = new Film("Death note", " Shūsuke Kaneko", 126, new string[] { "Thriller" });

List<Film> ListaFilm = new List<Film>() { film1, film2, film3 };

foreach (var film in ListaFilm)
    {
    film.StampaFilm();
    }

