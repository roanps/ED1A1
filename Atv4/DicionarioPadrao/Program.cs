﻿/* Diferente da TabelaHash, o Dictionary  nos permite especificar o tipo de dado
que será utilizado nos pares
 Key -> Value
Isso nos fornece uma estrutura fortemente tipada*/

using dicPessoa;

Dictionary<string, string> dictionary =
    new Dictionary<string, string>()
{
    { "Chave 1", "Valor 1" },
    { "Chave 2", "Valor 2" },
};

// Obter valor do dictionary
string val = dictionary["Chave 1"];

try
{
    val = dictionary["Chave 3"];
}
catch(Exception ex)
{
    Console.WriteLine("Erro ao obter valor de Chave 3");
    Console.WriteLine(ex.Message);
}

// Verificando se a chave existe antes de acessar
// para evitar erros e prejuízos de execução
if(dictionary.ContainsKey("Chave 2"))
{
    Console.WriteLine($"Chave 2: {dictionary["Chave 2"]}");
}

// Outra forma de obter o valor e evitar erro
dictionary.TryGetValue("Chave 4", out string? valor);
if(valor is not null)
    Console.WriteLine($"Chave 4: {valor}");

// Podemos adicionar da mesma forma pela chave inexistente
dictionary["Chave 0"] = "Valor 0";

// Percorrer o dicionário
foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}

// Utilizando Tipos Abstratos de Dados com Dicionario

Dictiornary<int, Pessoa> dicPessoa = 
    new Dictiornary<int, Pessoa>();

dicPessoa.Add(
    1,
     new Pessoa(){
        Id = 0,
        BirthDate = new DateTime(2001, 12, 21),
        nameof = "Roan Poggere da SIlva"
     });

  dicPessoa.Add(
    2,
     new Pessoa(){
        Id = 0,
        BirthDate = new DateTime(1984, 12, 21),
        nameof = "Mauricio Roberto Gonzzato"
     });

    foreach( KeyValuePair<int, Pessoa> kvp in dicPessoa){
        Console.WriteLine(kvp.Key);
        Console.WriteLine(kvp.Value.Id);
        Console.WriteLine(kvp.Value.Name);
        Console.WriteLine(kvp.Value.BirthDate);
    }