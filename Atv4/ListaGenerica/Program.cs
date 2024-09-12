﻿using System.Runtime.CompilerServices;
using ListaGenerica;

List <double>  numbers = new List<double>();

do{
    Console.WriteLine("Informe um número: ");
    string? numberStr = Console.ReadLine();
    //Validando a entrada do usuário
    if(!double.TryParse(numberStr, out double number))  {
        break;
    }    

    numbers.Add(number);
    
    Console.WriteLine($"A média dos valores é {numbers.Average()}");

}while (true);

// ---- Lista de Pessoas
List<Person> people = new List<Person>();
Person p1 = new Person();
p1.Name = "Joaquim";
p1.Age = 12;
p1.Country = CountryEnum.PY;
people.Add(p1); 

people.Add(new Person(){
    Name = "Sharon Stone",
    Age = 60,
    Country = CountryEnum.PY,
});

Person p3 = new Person(){
    Name = "Arnold E-SuasNega",
    Age = 65,
    Country = CountryEnum.JP,
};
people.Add(p3);


//Formas de percorrer a lista Genérica
foreach(Person p in people){
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Age);
    Console.WriteLine(p.Country);
}

//Modo for tradicional
for(int i=0; i<people.Count; i++){
    Console.WriteLine(people[i].Name);
    Console.WriteLine(people[i].Age);
    Console.WriteLine(people[i].Country);
}