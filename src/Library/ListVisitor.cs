using System.Collections.Generic;
namespace Library;


public class ListVisitor: IVisitor
{
    private List<Person> lista = new List<Person>();

    public List<Person> Lista
    {
        get
        {
            return this.lista;
        }
    }

    public void Visit(Node node)
    {
        lista.Add(node.Person);
    }
}