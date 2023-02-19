namespace EduCenter.Domain.Commons;

public class Auditable
{
    public int Id { get; set; }
    public DateTime AddedAt { get; set; }
    public DateTime UpdatedAt { get; set;}
}
