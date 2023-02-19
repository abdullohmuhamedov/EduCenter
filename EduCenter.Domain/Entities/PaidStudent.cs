using EduCenter.Domain.Commons;
using EduCenter.Domain.Enums;

namespace EduCenter.Domain.Entities;

public class PaidStudent : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int DateOfBirth { get; set; }
    public DateTime? PaidAt { get; set; }
    public PaymentType PaymentType { get; set; }
    public SubjectType SubjectType { get; set; }
}
