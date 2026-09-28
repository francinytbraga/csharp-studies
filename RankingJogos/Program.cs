List<string> meusJogos = new List<string>();
meusJogos.Add("GOD OF WAR");
meusJogos.Add("GTA VI");
meusJogos.Add("GHOST OF TSUSHIMA");
meusJogos.Add("RED DEAD REDEMPTION");

for(int i = 0; i < meusJogos.Count; i++)
{
    Console.WriteLine($"{i + 1}: {meusJogos[i]}");
} 