namespace Library;

public class Person
{
    private string _name;
    private int _age;
    private List<Person> _children = new List<Person>();
    public string Name { get; set; }
    public int Age { get; set; }
    public List<Person> Children { get; set; } = new List<Person>();
    
    public void AddChildren(Person child)
    {
        if (child != null)
        {
            Children.Add(child);
        }
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

}