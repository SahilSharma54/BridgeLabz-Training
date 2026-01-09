using System;
using System.Collections;

class CustomHashMap
{
    class Node
    {
        public int key;
        public int value;
        public Node next;

        public Node(int k, int v)
        {
            key = k;
            value = v;
            next = null;
        }
    }

    static Node[] table = new Node[5];

    static int Hash(int key)
    {
        return key % table.Length;
    }

    static void Put(int key, int value)
    {
        int index = Hash(key);
        Node newNode = new Node(key, value);

        if (table[index] == null)
        {
            table[index] = newNode;
            return;
        }

        Node temp = table[index];
        while (temp.next != null)
            temp = temp.next;

        temp.next = newNode;
    }

    static void Get(int key)
    {
        int index = Hash(key);
        Node temp = table[index];

        while (temp != null)
        {
            if (temp.key == key)
            {
                Console.WriteLine("Value: " + temp.value);
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Key not found");
    }

    static void Main()
    {
        Put(1, 100);
        Put(6, 200);
        Put(11, 300);

        Get(6);
        Get(10);
    }
}
