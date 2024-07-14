﻿Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//TestaArrayInt();
TestaBuscarPalavra();


void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 65;
    idades[2] = 29;
    idades[3] = 50;
    idades[4] = 17;


    Console.WriteLine($"Tamanho do Array {idades.Length}");
    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idades[i]}");
        acumulador+= idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");

}


void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string [5];

    for (int i = 0;i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite = {i+1}ª Palavra:");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}