using OOP.AbstractClassandMethodApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var arr = new int[] { 1, 5, 4, 3, 7 };
        var minheap = new MinHeap();
        var maxheap = new MaxHeap();
        
        //sınıflardaki listelere arr deki elemanları ekleme
        foreach (var item in arr)
        {
            minheap.Insert(item);
            maxheap.Insert(item);
        }

        Console.WriteLine(minheap.Extract());
        Console.WriteLine(maxheap.Extract());


        Console.ReadKey();
    }
}