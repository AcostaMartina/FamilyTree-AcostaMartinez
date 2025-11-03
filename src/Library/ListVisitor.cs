namespace Library;

public class ListVisitor: IVisitor
{
    private List<string> lista = new List<string>();

    public List<string> Lista
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
