using Nuget.Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda V1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
Venda V2 = new Venda(1, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(V1);
listaVendas.Add(V2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado); // Ele cria o formato Json ou qualquer formato.

System.Console.WriteLine(serializado);
