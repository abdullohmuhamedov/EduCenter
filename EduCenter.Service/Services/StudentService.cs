using EduCenter.Domain.Entities;
using EduCenter.Service.DTOs;
using EduCenter.Service.Helpers;
using EduCenter.Service.Interfaces;

namespace EduCenter.Service.Services;

public class StudentService : IStudentService
{
    public Task<Response<Student>> CreateAsync(StudentCreationDto student)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Student>> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ListResponse> GetAllAsync(Func<Student, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Student>> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Response<Student>> UpdateAsync(int id, StudentCreationDto student)
    {
        throw new NotImplementedException();
    }
}
