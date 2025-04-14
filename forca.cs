// Declara os parâmetros: palavra secreta e numero de tentativas 
string palavra = "austeridade";
int tentativas = 6;
 
// Inicia variáveis do código 
int tentativa_atual = 0;
HashSet<int> posicoes_adivinhadas = new HashSet<int>();
char chute;

int verifica(char chute)
{
    for(int i = 0; i < palavra.Length; i++){
        if (palavra[i] == chute)
        {
            return i;
        }
    return -1; 
    }
}

void printa_palavra(HashSet<int> posicoes_adivinhadas)
{
    for(int i = 0; i < palavra.Length; i++){
        if (posicoes.Contains(i))
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
    Console.Write("Chute apenas uma letra, em minúsculo: ");
    char chute = Console.ReadLine();
    return chute;
}

void forca()
{
    while (tentativa_atual <= tentativas)
    {
        Console.WriteLine("Tentativa: " + tentativa_atual);
        printa_palavra(posicoes_adivinhadas);
        chute = leitor_chute();
        posicao = verifica(chute);
        if(posicao == -1)
        {
            Console.WriteLine("Errou!");
            tentativa_atual++;
            continue;
        }
        else:
            posicoes_adivinhadas.Add(posicao)
            continue;
    }
}

forca();