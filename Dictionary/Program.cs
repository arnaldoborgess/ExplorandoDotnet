
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

System.Console.WriteLine("\n-------------------------------------------");

estados.Remove("SP");
estados["BA"] = "Bahia - Valor Alterado";

foreach (var item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

System.Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++");

string chave = "SP";
System.Console.WriteLine("Verificando o elemento");

if (estados.ContainsKey(chave))
{
    System.Console.WriteLine($"Valor existente: {chave}");
}
else
{
    System.Console.WriteLine($"Valor não existe é seguro adicionar a chave : {chave}");
}

System.Console.WriteLine("\n=============== Obtendo um valor que já existe ==================");

System.Console.WriteLine(estados["MG"]);