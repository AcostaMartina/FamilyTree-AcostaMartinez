namespace Library;

public class AgeVisitor : IVisitor
{
    private int sum = 0;

    public int Sum
    {
        get
        {
            return this.sum;
        }
    }

    public void Visit(Node node)
    {
        sum += node.Person.Age;
    
    }
}