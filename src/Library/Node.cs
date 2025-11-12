namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node
{
    private Person person;

    private List<Node> children = new List<Node>();

    public Person Person {
        get
        {
            return this.person;
        }
    }

    public ReadOnlyCollection<Node> Children {
        get
        {
            return this.children.AsReadOnly();
        }
    }

    public Node(Person persona)
    {
        this.person = persona;
    }

    public void AddChildren(Node n)
    {
        this.children.Add(n);
    }
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        foreach (var item in this.children)
        {
            item.Accept(visitor);
        }
    }

    public bool IsLeaf
    {
        get { return this.Children.Count == 0; }
    }
}