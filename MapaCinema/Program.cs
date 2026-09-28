string[,] assentos = new string[2,2]
{
    {"ANA","BRUNO"},
    {"CARLOS", "DIANA"}
};
string lugar = assentos[0,0];
Console.WriteLine($"o lugar de {lugar} esta ocupado");

for(int i = 0; i <= assentos.GetUpperBound(0); i++)
{
    for(int j = 0; j <= assentos.GetUpperBound(1); j++)
    {
        Console.WriteLine($"o assento [{i},{j}] está ocupado por {assentos[i,j]}");

    }
}