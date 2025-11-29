Console.WriteLine("### Condicional Else ###\n");

Console.WriteLine("Informe sua idade : ");
var idade = int.Parse(Console.ReadLine()!);

Console.WriteLine("Possui passaporte (S/N)");
var passaporte = Console.ReadLine();

Console.WriteLine("Possui visto válido (S/N)");
var visto = Console.ReadLine();

Console.WriteLine("Pontuação de risco (0/100)");
var pontuacao = int.Parse(Console.ReadLine()!);

Console.WriteLine("Origem da viagem (Nacional/Internacional)");
var origemViagem = Console.ReadLine();

bool viagemInternacional = origemViagem == "Internacional";
bool temPassaporte = passaporte == "Sim";
bool temVisto = visto == "Sim";

if ((viagemInternacional && idade < 18) ||
    (viagemInternacional && temPassaporte) ||
    (pontuacao >= 70))
{
    Console.WriteLine("Viagem negada!");
} 

else if ((viagemInternacional && temPassaporte && !temVisto) ||
    (pontuacao >= 40 && pontuacao <= 69))
{
    Console.WriteLine("Viagem em analise!");
} 

else if ((idade >= 18 &&
        pontuacao < 40 &&
    (temPassaporte && temVisto)))
{
    Console.WriteLine("Viagem Aprovada!");
}

else
{
    Console.WriteLine("Opção Invalida!");
}

Console.ReadKey();
