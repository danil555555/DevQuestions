namespace DevQuestions.Domain.Tag;

public class Tag
{
    public Guid Id { get; private set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    
}