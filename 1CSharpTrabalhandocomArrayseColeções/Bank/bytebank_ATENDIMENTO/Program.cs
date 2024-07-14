Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
TestaArrayInt();


void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 65;
    idades[2] = 29;
    idades[3] = 50;
    idades[4] = 17;


    Console.WriteLine($"Tamanho do Array {idades.Length}");

    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idades[i]}");
    }


}