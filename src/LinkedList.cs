using System;

namespace LinkedListExample
{
    public class LinkedList
    {
        // Classe Node dentro de LinkedList
        private class Node
        {
            public int Data; // Dados do nó
            public Node? Next; // Ponteiro para o próximo nó

            // Construtor
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node? head; // Ponteiro para o primeiro nó da lista

        // Construtor
        public LinkedList()
        {
            head = null;
        }

        // Método para adicionar um nó no final da lista 
        public void Add(int data)
        {
            Node newNode = new Node(data);

            // Se a lista estiver vazia
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Define o próximo nó do último nó com o novo nó
                current.Next = newNode;
            }
        }

        // Método para exibir todos os elementos da lista
        public void Display()
        {

            if (head == null)
            {
                Console.WriteLine("A lista está vazia");
                return;
            }

            Node? current = head;
            while (current != null)
            {
                Console.Write(current.Data);

                if (current.Next != null)
                {
                    Console.Write(" -> ");
                }
                current = current.Next;

            }
            Console.WriteLine();
        }

        // Método para remover o primeiro nó da lista
        public void Remove(int value)
        {
            if (head == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            // Se o nó a ser removido for o primeiro
            if (head.Data == value)
            {
                head = head.Next;
                return;
            }

            // Busca o no com o valor e o remove
            Node current = head;
            while (current.Next != null && current.Next.Data != value)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.WriteLine("Valor não encontrado.");
                return;
            }
            current.Next = current.Next?.Next;
        }
    }
}