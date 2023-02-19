using EduCenter.Domain.Entities;

namespace EduCenter.Service.Helpers;

public class PaidResponse
{
    public int StatusCode { get; set; }
    public string Message { get; set; }

    public PaidStudent PaidStudent { get; set; }
}
