using EduCenter.Domain.Enums;

namespace EduCenter.Service.DTOs;

public class PaymentCreationDto
{
    public int Id { get; set; }
    public PaymentType Type { get; set; }
    public bool IsPaid { get; set; }
}
