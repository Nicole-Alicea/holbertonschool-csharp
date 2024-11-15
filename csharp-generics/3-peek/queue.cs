using System;

/// <summary>
/// Class for Queue operations.
/// </summary>
class Queue<T>
{
    public class Node
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public T value { get; set; }

        /// <summary>
        /// The next node in the queue.
        /// </summary>
        public Node next { get; set; }

        /// <summary>
        /// Initializes a new node with the given value.
        /// </summary>
        /// <param name="value"> The value to store in the node. </param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>
    /// The head of the queue.
    /// </summary>
    public Node head { get; private set; }

    /// <summary>
    /// The tail of the queue.
    /// </summary>
    public Node tail { get; private set; }

    /// <summary>
    /// The number of nodes in the queue.
    /// </summary>
    public int count { get; private set; }

    /// <summary>
    /// Initializes a new instance of the Queue class.
    /// </summary>
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    /// <summary>
    /// Adds a new node to the end of the queue.
    /// </summary>
    /// <param name="value"> The value to add to the queue. </param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }

        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>
    /// Removes and returns the value of the first node in the queue.
    /// </summary>
    /// <returns> The value of the dequeued node, or the default value of T if the queue is empty. </returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;
        count--;

        if (head == null)
        {
            tail = null;
        }

        return value;
    }

    /// <summary>
    /// Returns the value of the first node in the queue without removing it.
    /// </summary>
    /// <returns>
    /// The value of the first node, or the default value of T if the queue is empty.
    /// </returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    /// <summary>
    /// Returns the number of nodes in the queue.
    /// </summary>
    /// <returns> The number of nodes in the queue. </returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Checks and returns the type of a Queue.
    /// </summary>
    /// <returns> A Queue's type. </returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}