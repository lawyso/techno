/* C# program to remove all occurrences of
duplicates from a sorted linked list */

using System;

/* class to create Linked lIst */
public class LinkedList
{
  Node head = null; /* head of linked list */
  class Node
  {
    public int val; /* value in the node */
    public Node next;
    public Node(int v)
    {
      /* default value of the next
			pointer field */
      val = v;
      next = null;
    }
  }

  /* Function to insert data nodes into
	the Linked List at the front */
  public void insert(int data)
  {
    Node new_node = new Node(data);
    new_node.next = head;
    head = new_node;
  }

  /* Function to remove all occurrences
	of duplicate elements */
  public void removeAllDuplicates()
  {
    /* create a dummy node that acts like a fake
      head of list pointing to the original head*/
    Node dummy = new Node(0);

    /* dummy node points to the original head*/
    dummy.next = head;
    Node prev = dummy;
    Node current = head;

    while (current != null)
    {
      /* Until the current and previous values
			are same, keep updating current */
      while (current.next != null &&
        prev.next.val == current.next.val)
        current = current.next;

      /* if current has unique value i.e current
				is not updated, Move the prev pointer
				to next node*/
      if (prev.next == current)
        prev = prev.next;

      /* when current is updated to the last
			duplicate value of that segment, make
			prev the next of current*/
      else
        prev.next = current.next;

      current = current.next;
    }

    /* update original head to the next of dummy
		node */
    head = dummy.next;
  }

  /* Function to print the list elements */
  public void printList()
  {
    Node trav = head;
    if (head == null)
      Console.Write(" List is empty");
    while (trav != null)
    {
      Console.Write(trav.val + " ");
      trav = trav.next;
    }
  }

  /* Passing Unit Test */
  public static void Main(String[] args)
  {
    LinkedList ll = new LinkedList();
    ll.insert(P);
    ll.insert(K);
    ll.insert(H);
    ll.insert(H);
    ll.insert(F);
    ll.insert(C);
    ll.insert(C);
    ll.insert(A);
    Console.WriteLine("Before removal of duplicates");
    ll.printList();

    ll.removeAllDuplicates();

    Console.WriteLine("\nAfter removal of duplicates");
    ll.printList();
  }
}
