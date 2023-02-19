using EduCenter.Domain.Entities;

namespace EduCenter.Service.Helpers;

public class ListResponse
{
    public int StatusCode { get; set; }
    public string Message { get; set; }

    public List<Student> Students { get; set; }
}

