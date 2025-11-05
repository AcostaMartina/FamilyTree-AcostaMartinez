using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person abuelo = new Person("José Gonzalez", 72);
            Person abuela = new Person("Elizabeth",76);
            Person padre = new Person("Kanye West",47);
            Person madre = new Person("Laura Raffo",52);
            Person hijo = new Person("José Abadie",30);
            Person hijo2 = new Person("Luis Suarez",37);
            Person hija = new Person("Taylor Swift",35);

            
            Node n1 = new Node(abuelo);
            Node n2 = new Node(abuela);
            Node n3 = new Node(padre);
            Node n4 = new Node(madre);
            Node n5 = new Node(hijo);
            Node n6 = new Node(hijo2);
            Node n7 = new Node(hija);
            
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            abuelo.AddChildren(padre);
            abuela.AddChildren(madre);

            padre.AddChildren(hijo2);
            madre.AddChildren(hijo);
            padre.AddChildren(hijo);
            madre.AddChildren(hija);

            // visitar el árbol aquí
            ListVisitor visitor = new ListVisitor();
            AgeVisitor visitor2 = new AgeVisitor();
            OldVisitor visitor3 = new OldVisitor();
            LongestNameVisitor visitor4 = new LongestNameVisitor();
            n1.Accept(visitor2);
            n1.Accept(visitor3);
            n1.Accept(visitor4);
            n1.Accept(visitor);
            Console.WriteLine("Los hijos son:");
            string lista = "";
            foreach (Person humano in visitor.Lista)
            {
                lista +="|" +humano.Name + " "+ humano.Age+ "| ";
            }
            Console.WriteLine(lista);
            Console.WriteLine(visitor2.Sum);
            Console.WriteLine("La edad mayor es de: ");
            Console.WriteLine(visitor3.Older.Age);
            Console.WriteLine($"El nombre más largo es: {visitor4.Longest.Name}");
        }
    }
}