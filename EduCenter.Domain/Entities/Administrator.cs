using EduCenter.Domain.Commons;

namespace EduCenter.Domain.Entities;

public class Administrator : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}
