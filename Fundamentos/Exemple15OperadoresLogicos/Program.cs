Console.WriteLine("### Operadores Lógicos ###");

var x = 5;
var b = 33;

// Ambas as condições verdadeiras
if (x >= 5 && b >= 32)
{
    Console.WriteLine("Todas as condições são verdadeiras.");
}
// Pelo menos uma condição verdadeira
else if (x >= 5 || b > 33)
{
    Console.WriteLine("Pelo menos uma condição é verdadeira.");
}
else
{
    Console.WriteLine("Nenhuma condição é verdadeira.");
}

Console.ReadKey();