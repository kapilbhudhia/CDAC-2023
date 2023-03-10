// See https://aka.ms/new-console-template for more information
using IACSD_DEMO;

Console.WriteLine("Hello, World!");


Heap heap = new Heap();
List<int> elements = new List<int> { 23, 34, 45, -10, 15, 67, 99, 78, 100, 28, 100, -90, 89};

int K = 5;

foreach(int element in elements)
{
    if (heap.Count() < K)
    {
        heap.AddNewElement(element);

        heap.PrintTheHeap();

        Console.WriteLine();

    }
    else if (heap.Top() > element)
    {
        heap.ReplaceRootElement(element);
        heap.PrintTheHeap();
        Console.WriteLine();

    }
}


