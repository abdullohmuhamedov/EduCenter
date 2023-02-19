using EduCenter.Domain.Entities;
using EduCenter.Service.DTOs;
using EduCenter.Service.Helpers;

namespace EduCenter.Service.Interfaces;

public interface IStudentService
{
    Task<Response<Student>> CreateAsync(StudentCreationDto student);
    Task<Response<Student>> UpdateAsync(int id, StudentCreationDto student);
    Task<Response<Student>> DeleteAsync(int id);
    Task<Response<Student>> GetByIdAsync(int id);
    Task<ListResponse> GetAllAsync(Func<Student, bool> predicate);
}
