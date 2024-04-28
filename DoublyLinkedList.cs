public class DoublyLinkedList<T>
{
    private class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public DoublyLinkedList()
    {
        head = tail = null;
        count = 0;
    }
}