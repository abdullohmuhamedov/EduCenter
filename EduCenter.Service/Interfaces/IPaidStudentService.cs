using EduCenter.Domain.Entities;
using EduCenter.Service.DTOs;
using EduCenter.Service.Helpers;

namespace EduCenter.Service.Interfaces;

public interface IPaidStudentService
{
    Task<PaidResponse> AddPaymentAsync(int id, PaymentCreationDto payment);
    Task<PaidListResponse> GetAllPaidStudentAsync();
}
