
//using ScreenSound;

//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A Night at The Opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = false,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = true,
//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();

//queen.AdicionarAlbum(albumDoQueen);
//queen.Discografia();

//albumDoQueen.ExibirMusicasDoAlbum();

using ScreenSound;

Episodios ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");
Console.WriteLine(ep1.Resumo);

Episodios ep2 = new(1, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
Console.WriteLine(ep2.Resumo);

Console.WriteLine("\n***************************************************");

Podcast podcast = new("Daniel", "Podcast Especial");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();