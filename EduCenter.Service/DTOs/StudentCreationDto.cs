using EduCenter.Domain.Enums;

namespace EduCenter.Service.DTOs;

public class StudentCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public SubjectType Type { get; set; }
}
