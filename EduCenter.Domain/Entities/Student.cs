using EduCenter.Domain.Commons;
using EduCenter.Domain.Enums;

namespace EduCenter.Domain.Entities;

public class Student : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public SubjectType SubjectType { get; set; }
}
