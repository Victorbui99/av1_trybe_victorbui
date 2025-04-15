using System;

int leitor_chute()
{
    string  entrada;
    int chute;

    while(true)
    {
        Console.Write("Chute um número inteiro: ");
        entrada = Console.ReadLine();
        if (int.TryParse(entrada, out chute))
        {
            return chute;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}

int diferenca (int chute, int resposta)
{
    return resposta - chute;
}

int abs(int numero)
{
    if (numero > 0)
    {
        return numero;
    }
    else
        return -1 * numero;
}
void processa_diferenca (int diferenca)
{
    if (diferenca > 0)
    {
        Console.WriteLine("Chute mais alto!");
    }
    else
    {
        Console.WriteLine("Chute mais baixo!");
    }
    if (abs(diferenca) >= 100)
    {
        Console.WriteLine("Está muito distante!");
    }
    else if (abs(diferenca) >= 50)
    {
        Console.WriteLine("Está distante!");
    }
    else
    {
        Console.WriteLine("Está perto!");
    }
}

void jogo(int resposta)
{
    int chute, dif;
    while(true)
    {
        Console.WriteLine();
        Console.WriteLine("===============");
        chute = leitor_chute();
        dif = diferenca(chute,resposta);
        if (dif == 0)
        {
            Console.WriteLine("Você acertou!");
            return;
        }
        else
        {
            processa_diferenca(dif);
            Console.WriteLine("Agora tente de novo!");
        }
    }
}

// Declara os parâmetros: resposta 
int resposta = 150;

// Inicia o jogo
jogo(resposta);