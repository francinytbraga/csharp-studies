using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        List<string> passageiros = new List<string>();
        string continuar = "s";

        Console.WriteLine("=== SISTEMA DE EMBARQUE ===");
        while (continuar == "s" || continuar == "sim")
        {
            string entradaNome = string.Empty;
            string acompanhante = string.Empty;
            int idade = 0;
            int pesoMala = 0;

            bool nomeValido = false;
            do
            {
                Console.Write("Digite seu nome completo: ");
                entradaNome = Console.ReadLine()?.Trim() ?? string.Empty;

                bool tamanhoNome = entradaNome.Length >= 10;
                bool formatoValido = Regex.IsMatch(entradaNome, @"^[a-zA-ZÀ-ÿ\s]+$");

                if (tamanhoNome && formatoValido)
                {
                    nomeValido = true;
                }
                else
                {
                    Console.WriteLine("Nome inválido! Deve ter mais de 10 letras, contendo apenas letras e espaços.");
                }
            } while (!nomeValido);

            bool idadeValida = false;
            do
            {
                Console.Write("Digite sua idade: ");
                string entradaIdade = Console.ReadLine()?.Trim() ?? string.Empty;

                if (int.TryParse(entradaIdade, out idade))
                {
                    if (idade >= 18 && idade < 120)
                    {
                        idadeValida = true;
                    }
                    else if (idade > 0 && idade < 18)
                    {
                        Console.WriteLine($"{entradaNome}, menor de idade. Tem acompanhante? (s/n)");
                        acompanhante = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

                        if (acompanhante == "sim" || acompanhante == "s")
                        {
                            idadeValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Sem acompanhante. Não é possível embarcar.");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Digite apenas números inteiros para a idade.");
                }
            } while (!idadeValida);

            if (!idadeValida)
            {
                Console.WriteLine("Deseja tentar cadastrar outro passageiro? (s/n): ");
                continuar = Console.ReadLine()?.Trim().ToLower() ?? "n";
                continue;
            }

            bool pesoValido = false;
            do
            {
                Console.Write("Qual o peso da mala (em kg)? ");
                string entradaPeso = Console.ReadLine()?.Trim() ?? string.Empty;

                if (int.TryParse(entradaPeso, out pesoMala))
                {
                    if (pesoMala >= 0 && pesoMala <= 35)
                    {
                        pesoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Peso excedido! O limite é 35kg.");
                    }
                }
                else
                {
                    Console.WriteLine("Digite um número válido para o peso.");
                }
            } while (!pesoValido);

            passageiros.Add(entradaNome);
            Console.WriteLine($"Sucesso! {entradaNome} foi adicionado(a) à lista de passageiros.");

            Console.Write("\nDeseja cadastrar outro passageiro? (s/n): ");
            continuar = Console.ReadLine()?.Trim().ToLower() ?? "n";
        }
        Console.WriteLine("\n=== LISTA FINAL DE PASSAGEIROS EMBARCADOS ===");
        foreach (var p in passageiros)
        {
            Console.WriteLine($"- {p}");
        }
    }
}