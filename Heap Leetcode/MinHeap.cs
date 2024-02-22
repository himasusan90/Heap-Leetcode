// See https://aka.ms/new-console-template for more information
public class MinHeap
{
    public List<int> Heap { get; set; } = new List<int>();

    public void Add(int x)
    {
        Heap.Add(x);
        HeapifyUp(Heap.Count - 1);
    }

    public int Pop()
    {
        if (Heap.Count == 0) throw new InvalidOperationException("Heap is empty.");

        int value = Heap[0];
        Heap[0] = Heap[Heap.Count - 1];
        Heap.RemoveAt(Heap.Count - 1);
        if (Heap.Count > 0)
        {
            HeapifyDown(0);
        }

        return value;

    }

    private void HeapifyDown(int index)
    {
        int minIndex = index;
        int leftIndex = 2 * index + 1;
        int rightIndex = 2 * index + 2;
        if (leftIndex < Heap.Count && Heap[minIndex] > Heap[leftIndex])
        {

            minIndex = leftIndex;
        }
        if (rightIndex < Heap.Count && Heap[minIndex] > Heap[rightIndex])
        {

            minIndex = rightIndex;
        }
        if (minIndex != index)
        {
            Swap(minIndex, index);
            HeapifyDown(minIndex);
        }

    }


    private void HeapifyUp(int index)
    {
        if (index == 0) return; // The root of the heap has no parent
        int parentIndex = (index - 1) / 2;

        if (Heap[parentIndex] > Heap[index])
        {
            Swap(parentIndex, index);
            HeapifyUp(parentIndex);
        }

    }

    private void Swap(int parentIndex, int index)
    {
        int temp = Heap[parentIndex];
        Heap[parentIndex] = Heap[index];
        Heap[index] = temp;
    }
}