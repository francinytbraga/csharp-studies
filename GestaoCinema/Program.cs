using System.Runtime.Intrinsics.X86;

List<string> filmes = new List<string>();
List<string> filmesContrario = new List<string>();
filmes.Add("HARRY POTTER");
filmes.Add("MADAGASCAR");
filmes.Add("PROCURANDO O NOME");
filmes.Add("TOY STORY");

for(int i = 0; i <filmes.Count; i++)
{
    Console.WriteLine($"[{i+1}]: {filmes[i]}");
    
}
int contador = 1;
for(int j = filmes.Count - 1; j >= 0; j--)
{
    Console.WriteLine($"[{contador}]: {filmes[j]}");
    filmesContrario.Add(filmes[j]);
    contador++;
    
}
if(filmesContrario.SequenceEqual(filmes))
{
    Console.WriteLine($"Os filmes são iguais ao contrario.");
} else
{
    Console.WriteLine($"Os filmes não são iguais ao contrario");
}

bool saoIguais = true;

if(filmes.Count != filmesContrario.Count)
{
    Console.WriteLine($"As listas não são iguais em tamanho");
} else
{
    for(int k = 0; k < filmes.Count; k++)
    {
        if(filmes[k] != filmesContrario[k])
        {
            saoIguais = false;
            break;
        }
    }
}
if(saoIguais)
{
    Console.WriteLine("As listas de filmes são iguais.");
} else
{
    Console.WriteLine("As listas de filmes não são iguais.");
}

if(filmes.Contains("HARRY POTTER"))
{
    Console.WriteLine($"O filme HARRY POTTER está em cartaz.");
} else
{
    Console.WriteLine($"O filme HARRY POTTER não está em cartaz. ");
}

decimal precoNormal = 40m;
decimal? cupomDesconto = null;
decimal descontoPadrao = cupomDesconto ?? 10.00m;
decimal precoFinalDesconto = precoNormal - descontoPadrao;
int age = 59;
bool carteiraEstudante = true;

if(age < 18 && carteiraEstudante == true || age >= 60)
{
   Console.WriteLine($"Preco com desconto para estudante/idoso: {precoFinalDesconto}");
   Console.WriteLine($"Preço SUPER ECONOMICO");
} else if(age > 18 || age < 60 || carteiraEstudante == false)
{
     Console.WriteLine($"O valor do ingresso é: {precoNormal}");
     Console.WriteLine($"Preço normal!");
}

string[,] assentos = new string[2,2]
{
    {"OCUPADO", "LIVRE"},
    {"LIVRE", "OCUPADO"}
};

for(int i= 0; i <= assentos.GetUpperBound(0); i++)
{
    for(int j= 0; j <= assentos.GetUpperBound(1); j++)
    {
        Console.WriteLine($"Lugares: [{i}{j}] está {assentos[i,j]}");
    }
}