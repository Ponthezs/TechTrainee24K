Musica musica1 = new Musica();
 
musica1.Nome = "3 Dias Virados";
musica1.Artista = "IG";
musica1.Duracao = 312;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);


Musica musica2 = new Musica();
musica2.Nome = "Roxane";
musica2.Artista = "The Police";
musica2.Duracao = 215;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
