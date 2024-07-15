Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//TestaArrayInt();
//TestaBuscarPalavra();


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

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 0);
amostra.SetValue(7.1, 0);
amostra.SetValue(10, 0);
amostra.SetValue(6.9, 0);

// [5,9]  [1,8] [7,1] [10] [6,9]

//TesteMediana(amostra);
void TesteMediana(Array array)
{
    if ((array == null) || (array.Length==0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo");
    }

    double[] numerosOrdenados = (double [])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

   int tamanho = numerosOrdenados.Length;
   int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                                            (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

int[] valores = { 10, 58, 36, 47 };
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(valores[i]);
}


