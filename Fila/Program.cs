
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    System.Console.WriteLine(item);
}
// Remover um elemento da fila

System.Console.WriteLine($"Removendo o elemento : {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item in fila)
{
    System.Console.WriteLine(item);
}