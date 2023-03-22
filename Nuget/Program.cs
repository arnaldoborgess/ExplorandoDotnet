using Nuget.Models;
using Newtonsoft.Json;

Venda V1 = new Venda(1, "Material de Escritório", 25.00M);

string serializado = JsonConvert.SerializeObject(V1, Formatting.Indented);

System.Console.WriteLine(serializado);
