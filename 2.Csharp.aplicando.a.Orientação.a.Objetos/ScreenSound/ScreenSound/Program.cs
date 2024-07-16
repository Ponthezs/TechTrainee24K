Banda queen = new Banda("Queen");


Album albumDoQueen = new Album("A night at the opera");


Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 190,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

Episodio ep1 = new(4, "Técnicas de Facilitação", 45);
Console.WriteLine(ep1.Resumo);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");