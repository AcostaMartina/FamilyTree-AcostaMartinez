namespace Library;

public class LongestNameVisitor: IVisitor
 
{

    private Person longest;

    public Person Longest
    {
        get
        {
            return this.longest;
        }
    }

    public void Visit(Node node)
    {
        if (Longest == null || node.Person.Name.Length > longest.Name.Length)
        {
            longest = node.Person;
        }
    }
}