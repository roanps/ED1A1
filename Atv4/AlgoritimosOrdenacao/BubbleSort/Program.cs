using BubbleSort;

int[] inteiros = [0, 12, 7, 1, 2, 8];

//Console.WriteLine(inteiros.ToString());
/*
Console.Write("[");
foreach (int i in inteiros){
    Console.Write(i + " ");
}
Console.Write("]");
*/
//Mostrar lista desordenada
BubbleSort.BubbleSort.Print(inteiros);

//Ordenar lista
BubbleSort.BubbleSort.Sort(inteiros);

//Mostra a lista ordenada
BubbleSort.BubbleSort.Print(inteiros);

Console.WriteLine("Teste Char");

char[] chars = ['x', 'z', 'b', 'c', 'a'];
BubbleSort.BubbleSort.Print(chars);
BubbleSort.BubbleSort.Sort(chars);
BubbleSort.BubbleSort.Print(chars);