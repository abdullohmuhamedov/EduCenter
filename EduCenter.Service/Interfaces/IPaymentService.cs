using EduCenter.Domain.Entities;
using EduCenter.Service.DTOs;
using EduCenter.Service.Helpers;

namespace EduCenter.Service.Interfaces; 

public interface IPaymentService 
{
    Task<Response<Payment>> CreateAsync(PaymentCreationDto payment);
    Task<Response<Payment>> UpdateAsync(long id, PaymentCreationDto payment);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<Payment>> GetByIdAsync(long id);
    Task<Response<List<Payment>>> GetAllAsync();
}
