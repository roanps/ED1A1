using Aula01;

int number;

//aTRIBUINDO VALOr
number = 10;

//Declarando constante
const int DAYS_IN_WEEK = 7;

//Imprimindo String concatenada
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} DIAS.");

// new TipoEnumerador() -> Invoca o método construtor do objeto 
// Toda classe tem o seu construtor padrão implicito sem argumentos/parametros
//É oisspivel sobreescrever este método especificando argumentos
//Todavia,, se o fizermos, perdemos o original i,plícito e precisaremos defini-lo explicitamente

TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish = 
    tipoEnum.GetLanguageEnum("inglês");

Console.WriteLine($"O enum de english é {enumEnglish}" );
