Console.WriteLine("### Utilizando operadores ###\n");

#region Operadores aritimeticos
//Console.WriteLine("Soma");
//var a = 2;
//var b = 3;
//var soma = a + b;
//Console.WriteLine($"A soma de {a} + {b} é: {soma}");

//Console.WriteLine("\nSubtração ");
//var c = 2;
//var d = 3;
//var subtracao = c + d;
//Console.WriteLine($"A subtração de {c} + {d} é: {subtracao}");

//Console.WriteLine("\nMultiplicação");
//var e = 10;
//var f = 20;
//var multipliacao = e + f;
//Console.WriteLine($"A multiplicação de {e} + {f} é : {multipliacao}");

//Console.WriteLine("\nDivisão");
//var g = 2;
//var h = 3;
//var divisao = g / h;
//Console.WriteLine($"A Divisão de {g} + {h} é: {divisao}");
#endregion

#region Operadores de Atribuição
var x = 2;
x += 3;
Console.WriteLine($"Utilizando o operador de atribuição ( += ) : {x}");

var b = 2;
b -= 3;
// Valor fica ( -1 ) pois estamos dizendo que (b -= 3)
Console.WriteLine($"Utilizando o operador de atribuição ( -= ) : {b}");

var c = 2;
c = 3;
// valor atribuido é 2.
// Após a atribuição o valor fica 3.
Console.WriteLine($"Utilizando o operador de atribuição ( = ) : {c}");
#endregion

Console.ReadKey();