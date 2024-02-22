// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
MinHeap minHeap = new MinHeap();

// Add numbers to the heap
int[] numbersToAdd = { 5, 3, 8, 1, 2, 7 };
foreach (var num in numbersToAdd)
{
    Console.WriteLine($"Adding: {num}");
    minHeap.Add(num);
}

// Pop numbers from the heap and print them
Console.WriteLine("Popping numbers from the heap in ascending order:");
while (minHeap.Heap.Count > 0)
{
    int min = minHeap.Pop();
    Console.WriteLine(min);
}