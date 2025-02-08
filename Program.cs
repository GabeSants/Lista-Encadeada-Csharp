using System;
using LinkedListExample;

class Program
{
    static void Main()
    {
        // Criando uma instância da LinkedList e usando os métodos
        LinkedList list = new LinkedList();
        
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        list.Display();

        list.Remove(30);
        list.Remove(500);

        list.Display();

    }
}