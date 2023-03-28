bool? desejaReceberEmail = null;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value) // hasvalue ver se é diferente de nulo Value é o valor da variável.
// Se não quiser usar o hasvalue != null
{
    System.Console.WriteLine("O usuário optou por receber e-mail.");
}
else
{
    System.Console.WriteLine("O usuário não respondeu ou optou por não receber.");
}