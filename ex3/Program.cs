using System;
using System.Collections.Generic;
using System.Linq;

// funcao recebe string
// funcao que passa para lista a string sem espaços e toda minuscula
// funcao que inverte
// verificar se lista invertida = lista

string leitor()
{
    Console.Write("Digite uma frase ou palavra: ");
    string entrada = Console.ReadLine();
    return entrada;
}

List<char> lista(string entrada)
{
    List<char> resultado = new List<char>();
    foreach (char c in entrada)
    {
        if (c != ' ') // ignora espaços
        {
            resultado.Add(char.ToLower(c)); // converte para minúsculo
        }
    }
    return resultado;
}

static List<char> InverterLista(List<char> listaOriginal)
{
    List<char> listaInvertida = new List<char>(listaOriginal);
    listaInvertida.Reverse(); 
    return listaInvertida;
}

string palavra = leitor();
List<char> palavra_listada = lista(palavra);
List<char> palavra_listada_invertida = InverterLista(palavra_listada);

if (palavra_listada.SequenceEqual(palavra_listada_invertida))
{
    Console.WriteLine("É palíndromo");
} 
else
{
    Console.WriteLine("Não é palíndromo");
}