Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");

// Acresentando item
pilha.Push(20);

foreach(int item in pilha)
{
    System.Console.WriteLine(item);
}