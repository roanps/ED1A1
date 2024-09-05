using System.Collections;

// Utilizando a Lista Simples

ArrayList arrList = new();
arrList.Add(5);
arrList.Add("Mauricio");

// É possível adicionar um conjunto de calores de uma só vez

arrList.AddRange(new int[] {1, 2, 3,});
// O método .Add() insero o valor ao final do vetor

arrList.Insert(0,15);
//Já o método insert, me permite incluir o valor desejado na posição especificado no primeiro parâmetro

// Lendo valores da Lista
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

// percorrendo a Lista com foreach
foreach(object obj in arrList)
{
        {
            Console.WriteLine($" | {obj}");
    }
}

// obter o tamanho total da lista
int tamanho = arrList.Count;
Console.WriteLine(tamanho);

//obter a capacidade quantos poder ser armazenado
int capacidade = arrList.Capacity;
Console.WriteLine(capacidade);

// percorrendo no modo clássico
for(int i = 0; i < arrList.Count; i++)
{
    Console.Write( $" | {arrList[i]}" );
}

// Recursos importantes da Lista
// Verificar se um valor é contido na lista
bool contemNome = arrList.Contains("Mauricio");
if(!contemNome)
    Console.WriteLine("Nome não encontrado");

// Para saber o indico que contem o valor buscado
// Neste caso se o valor existir na lista ele retona o índice(número inteiro)
// Caso o valor não exista na lista, retorna -1

int indiceDoValor = arrList.IndexOf("Mauricio");
if(indiceDoValor >= 0)
    Console.WriteLine($"Mauricio esta em [{indiceDoValor}]");
else
    Console.WriteLine("É, realmente não tem");

// É possível remover itens da lista
arrList.Remove("Mauricio"); // Remove pelo valor
arrList.RemoveAt(4); //Remove pelo indice
arrList.RemoveRange(0,2);// O primeiro parametro é  o indice e o segundo é quantas casas após o  índice

// percorrendo no modo clássico
for(int i = 0; i < arrList.Count; i++)
{
    Console.Write( $" | {arrList[i]}" );
}
