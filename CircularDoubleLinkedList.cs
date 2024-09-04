namespace data_structures;

public class CircularDoubleLinkedList
{
    public Node Head;
    public int Count;

    public CircularDoubleLinkedList()
    {
        Head = null;
        Count = 0;
    }


    public void AddLast(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node Tail = Head.Prev;
            Tail.Next = newNode;
            newNode.Prev = Tail;
            newNode.Next = Head;
            Head.Prev = newNode;
        }
        Count++;
        
    }
    
    // next to try alone:
    // display 
    // remove (value)
    // remove (index)
    // find
    // addAfterIndex
    
}