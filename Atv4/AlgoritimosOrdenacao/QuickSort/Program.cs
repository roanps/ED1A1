// See https://aka.ms/new-console-template for more information

using QuickSort;


Console.WriteLine("Hello, World!");
int[] values = new int[] {0, 15, 24, 1, 3, 6, 12, 9};

QuickSort.QuickSort.Print<int>(values);
Console.WriteLine("Inicializando ordenação.");
QuickSort.QuickSort.Sort<int>(values, 0, (values.Length -1) );
Console.WriteLine("Finalizando ordenção. ");
QuickSort.QuickSort.Print<int>(values);


