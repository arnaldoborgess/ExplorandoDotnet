using Tuplas.Models;

/*
// 1 maneira de criar uma tupla - Essa consegue nomear o objeto

(int, string, string, decimal) tupla = (1, "Arnaldo", "Filho", 1.80M);

 
2 maneira de criar uma tupla - Não consegue nomear o objeto
ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Arnaldo", "Filho", 1.80M);

 3 maneira de criar uma tupla - Não consegue nomear o objeto
var outroExemploTuplaCreate = Tuple.Create (1, "Arnaldo", "Filho", 1.80M);

System.Console.WriteLine($"ID: {tupla.Item1}");
System.Console.WriteLine($"Nome: {tupla.Item2}");
System.Console.WriteLine($"Sobrenome: {tupla.Item3}");
System.Console.WriteLine($"Altura: {tupla.Item4}");

*/

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");


if (sucesso)
{
    System.Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        System.Console.WriteLine(linha);
    }
}
else
{
    System.Console.WriteLine("Não foi possível ler o arquivo");
}