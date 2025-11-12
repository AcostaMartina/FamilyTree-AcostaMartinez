namespace Library;

public class LeafVisitor : IVisitor
{

    private int _leafNodes = 0;
    
    public int LeafNodes
    {
        get { return _leafNodes; }
    }
    

    public void Visit(Node node)
    {
        if (node.IsLeaf)
        {
            this._leafNodes += 1;
        }
       
    }
}
