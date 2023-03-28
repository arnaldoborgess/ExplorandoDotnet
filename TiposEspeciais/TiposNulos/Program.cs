using Newtonsoft.Json;
using TiposNulos.Models;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Vendas> listaVenda = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

foreach (Vendas venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/YYYY HH:mm ")}" +
                      $"{(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
}



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


