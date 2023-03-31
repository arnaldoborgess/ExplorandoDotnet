using Newtonsoft.Json;
using TiposNulos.Models;


// CLASSE GENÉRICA

// Inteiro

MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

System.Console.WriteLine(arrayInteiro[0]);

// String

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Teste");

System.Console.WriteLine(arrayString[0]);

// Booleano

MeuArray<bool> arrayBool = new MeuArray<bool>();

arrayBool.AdicionarElementoArray(true);

System.Console.WriteLine(true);


// // TIPOS ANÔNIMOS

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Vendas> listaVenda = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco});

// foreach (var venda in listaAnonimo)
// {
//     System.Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }



// TIPO NULO

// foreach (Vendas venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                       $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/YYYY HH:mm ")}" +
//                       $"{(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }



// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value) // hasvalue ver se é diferente de nulo Value é o valor da variável.
// // Se não quiser usar o hasvalue != null
// {
//     System.Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else
// {
//     System.Console.WriteLine("O usuário não respondeu ou optou por não receber.");
// }


