namespace Api.Models;

public class PersonJob
{
    public int Id { get; set; }
    
    public Person Person { get; set; }
    
    public Job Job { get; set; }
}