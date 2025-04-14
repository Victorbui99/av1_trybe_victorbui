using System;
using System.Collections.Generic;

int verifica(char chute, string palavra)
{
    for(int i = 0; i < palavra.Length; i++){
        if (palavra[i] == chute)
        {
            return i;
        }
    }
    return -1; 
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

void Forca()
{
    // Declara os parâmetros: palavra secreta e numero de tentativas 
    string palavra = "austeridade";
    int tentativas = 6;
    
    // Inicia variáveis do código 
    int posicao;
    int tentativa_atual = 0;
    HashSet<int> posicoes_adivinhadas = new HashSet<int>();
    char chute;

    while (tentativa_atual <= tentativas)
    {
        Console.WriteLine();
        Console.WriteLine("Tentativa: " + tentativa_atual);
        printa_palavra(posicoes_adivinhadas, palavra);
        chute = leitor_chute();
        posicao = verifica(chute, palavra);
        if(posicao == -1)
        {
            Console.WriteLine("Errou!");
            tentativa_atual++;
            /* continue; */
        }
        else
        {
            Console.WriteLine("Acertou!");
            posicoes_adivinhadas.Add(posicao);
            /* continue; */
        }
    }
}

Forca();

/* tratar de:
    - palavra onde a mesma letra aparece varias vezes
    - chutes repetidos
    - mensagem ganhou / perdeu
 */