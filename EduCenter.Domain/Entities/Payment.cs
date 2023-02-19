using EduCenter.Domain.Commons;
using EduCenter.Domain.Enums;

namespace EduCenter.Domain.Entities;

public class Payment : Auditable
{
    public PaymentType Type { get; set; }
    public bool IsPaid { get; set; }
}
