namespace Library;

public class LongestNameVisitor
 
{

    private Person older;

    public Person Older
    {
        get
        {
            return this.older;
        }
    }

    public void Visit(Node node)
    {
        if (Older == null || node.Person.Age > older.Age)
        {
            older = node.Person;
        }
    }
}