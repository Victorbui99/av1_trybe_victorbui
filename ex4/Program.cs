using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

// funcao que lê nome, filtra
string leitor_nome()
{
    Console.Write("Insira um aluno: ");
    string nome = Console.ReadLine();
    return nome;
}
// funcao que lê nota, filtra
float leitor_nota(string aluno)
{
    float nota;
    while (true)
    {
        Console.Write("Insira a nota do aluno " + aluno + " : ");
        string entrada = Console.ReadLine();
        if(float.TryParse(entrada, out nota))
        {
            return nota; 
        }
        else
        {
            Console.WriteLine("Entrada inválida. Insira um número!");
        }
    }
}

// funcao que calcula media e retorna
float media(List<float> notas)
{
   if (notas == null || notas.Count == 0)
    {
        Console.WriteLine("A lista de notas nao pode estar vazia");
        return -1;
    }

   else{
        return notas.Average();
   }

}

// funcao que printa media, printa nome - nota
void printa(List<float> notas, List<string> nomes, float media)
{
    Console.WriteLine("==========================");
    Console.WriteLine("Média geral: " + media);
    Console.WriteLine("==========================");
    for(int i = 0; i < nomes.Count; i++)
    {
        Console.WriteLine();
        Console.Write("Aluno " + i+1 +": " + nomes[i]);
        Console.Write(" | nota: " + notas[i]);
    }
}

// funcao que roda as duas funcoes acima ate receber "end"
void compilador()
{   Console.WriteLine("Insira as informações a seguir. Digite end no campo aluno para encerrar");
    string entrada_nome;
    float entrada_nota;
    List<string> nomes = new List<string>();
    List<float> notas = new List<float>();

    entrada_nome = leitor_nome();
    entrada_nota = leitor_nota(entrada_nome);
    while(entrada_nome != "end")
    {  
        nomes.Add(entrada_nome);
        notas.Add(entrada_nota);
        entrada_nome = leitor_nome();
        if(entrada_nome != "end"){
            entrada_nota = leitor_nota(entrada_nome);
        }
    }
    float avg = media(notas);
    printa(notas,nomes,avg);
}

compilador();