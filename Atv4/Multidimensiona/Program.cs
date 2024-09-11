// Criando um vetor multidimensional
//Cin 5 linhas e 2 colunas
int[,] numbers = new int[5,2];

//Criando um vetor tridimensional
int[,,] trinumbers = new int[5,4,3];


// Podemos inicializar os valores do vetor no momento de sua declaração

int[,] iniNumbers = new int[,]{
    {9, 15, -9},
    {19, 25, -90},
    {29, 34, -91},
    {38,46,-92},
    {49,55,-93},
};

//para acessar os valores contidos neste tipo de variável
int valor = iniNumbers[0,2]; // nesta caso = 15;
Console.WriteLine($" iniNumers[0,1] == {valor}");


int maior = 0, i =0, j=0, posI=0, posJ=0;

for(i = 0; i<5; i++){
    for(j = 0; j<3; j++){
        if(i==0 && j==0){
            maior = iniNumbers[i,j];
            posI = i;
            posJ = j;
        }else{
            if(maior<iniNumbers[i,j]){
                maior=iniNumbers[i,j];
                posI = i;
                posJ = j;
            }

        }

    }
}

Console.WriteLine($" O valor maior eh {maior}, está na posição {posI},{posJ}");
