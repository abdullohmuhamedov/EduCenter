using EduCenter.Data.IRepositories;
using EduCenter.Data.Repositories;
using EduCenter.Domain.Entities;
using EduCenter.Domain.Commons;
using EduCenter.Service.DTOs;
using EduCenter.Service.Helpers;
using EduCenter.Service.Interfaces;

namespace EduCenter.Service.Services;

public class PaidStudentService : IPaidStudentService
{
    private readonly IGenericRepository<Student> studentRepository = new GenericRepository<Student>();
    private readonly IGenericRepository<PaidStudent> paidStudentRepository = new GenericRepository<PaidStudent>();
    public async Task<PaidResponse> AddPaymentAsync(int id, PaymentCreationDto payment)
    {
        var student = await studentRepository.GetByIdAsync(id);
        if (student is null)
            return new PaidResponse()
            {
                StatusCode = 404,
                Message = "Student Not Found",
                PaidStudent = null
            };
        var newPayment = new PaidStudent()
        {
            Id = id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            DateOfBirth = student.DateOfBirth,
            SubjectType = student.SubjectType,
            PaymentType = payment.Type,
            PaidAt = DateTime.Now,
        };
        var paidStudent = await paidStudentRepository.CreateAsync(newPayment);
        return new PaidResponse()
        {
            StatusCode = 200,
            Message = "Successfully paid!",
            PaidStudent = paidStudent
        };
    }

    public async Task<PaidListResponse> GetAllPaidStudentAsync()
    {
        var model = await paidStudentRepository.GetAllAsync(p => p.Id > 0);
        return new PaidListResponse()
        {
            StatusCode = 200,
            Message = "Success",
            PaidStudents = model
        };
    }
}
