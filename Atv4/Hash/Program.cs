﻿// Exemplo de uma agenda telefônica 

using System.Collections;

Hashtable phoneBook = new Hashtable(){
    //{"Chave", "Valor"},
    {"Thomazzi", "49-9961-0150"},
    {"Mauricio Gonzatto", "49-99975-8575"},
    {"Gazbriel Bianchi", "49-99105-8904"},
};

// É possível adicionar elementos de diversas formas
// Pelo própio índice chave inexistente
phoneBook["Thaigo Padilha"] = "49-99176-8255";

// Ou pelo método Add()
phoneBook.Add("Marcos Henrique", "49-99202-6169");

// Entretanto, a TabelaHash verifica se há
// duplicidade de chave e pode lançar uma
// Exception
try {
    phoneBook.Add("Mauricio Gonzatto", "49-99975-8575");
}catch(Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir valor repetido.");
    Console.WriteLine(ex.Message);
    throw ex;
}

// Percorrendo itens da HashTable
Console.WriteLine("Agenda telefônica: ");
if(phoneBook.Count == 0)
    Console.WriteLine("A agenda está vazia.");
else
    foreach(DictionaryEntry entry in phoneBook)
        Console.WriteLine($"{entry.Key}:{entry.Value}");