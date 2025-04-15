using System;
using System.Collections.Generic;

List<int> verifica(char chute, string palavra)
{
    List<int> posicoes = new List<int>();
    for(int i = 0; i < palavra.Length; i++){
        if (palavra[i] == chute)
        {
            posicoes.Add(i);
        }
    }
    return posicoes; 
}

void printa_palavra(HashSet<int> posicoes_adivinhadas, string palavra)
{
    for(int i = 0; i < palavra.Length; i++){
        if (posicoes_adivinhadas.Contains(i))
        {
            Console.Write(palavra[i]);
        }
        else
            Console.Write("_");
    }
    Console.WriteLine();
}

char leitor_chute()
{
    char chute;
    while (true)
    {
        Console.Write("Chute apenas uma letra, em minúsculo: ");
        string entrada = Console.ReadLine();
        if (entrada.Length == 1 && char.IsLetter(entrada[0]))
        {
            chute = entrada[0]; 
            break; 
        }
        else
        {
            Console.WriteLine("Entrada inválida. Insira uma letra!");
        }
    }

    return chute;
}

void Forca(string palavra, int tentativas)
{    
    Console.WriteLine("--------------------");
    Console.WriteLine("Bem vindo ao jogo!");
    // Inicia variáveis do código 
    List<int> posicoes = new List<int>();
    int tentativa_atual = 0;
    HashSet<int> posicoes_adivinhadas = new HashSet<int>();
    char chute;

    while (tentativa_atual <= tentativas)
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Tentativa: " + tentativa_atual);
        printa_palavra(posicoes_adivinhadas, palavra);
        chute = leitor_chute();
        posicoes = verifica(chute, palavra);
        if (posicoes.Count == 0)
        {
            Console.WriteLine("Errou!");
            tentativa_atual++;
        }
        else
        {
            Console.WriteLine("Acertou!");
            foreach (int p in posicoes)
            {
                posicoes_adivinhadas.Add(p);
            }
        }
    }
    Console.WriteLine("Fim de jogo!");
}

// Declara os parâmetros: palavra secreta e numero de tentativas 
string palavra = "austeridade";
int tentativas = 6;

// Inicia o jogo
Forca(palavra, tentativas);

/* tratar de:
    - palavra onde a mesma letra aparece varias vezes
    - chutes repetidos
    - mensagem ganhou / perdeu
 */