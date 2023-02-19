using EduCenter.Data.Configurations;
using EduCenter.Data.IRepositories;
using EduCenter.Domain.Commons;
using EduCenter.Domain.Entities;
using Newtonsoft.Json;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace EduCenter.Data.Repositories;

public class GenericRepository<TResult> : IGenericRepository<TResult> where TResult : Auditable
{
    private string path;
    public GenericRepository()
    {
        if (typeof(TResult) == typeof(Student))
        {
            path = DatabasePath.STUDENTS_PATH;
        }
        else if (typeof(TResult) == typeof(PaidStudent))
        {
            path = DatabasePath.PAID_STUDENTS_PATH;
        }
    }

    public async Task<TResult> CreateAsync(TResult value)
    {
        var students = await GetAllAsync(p => p.Id > 0);
        students.Add(value);

        var json = JsonConvert.SerializeObject(students, Formatting.Indented);
        await File.WriteAllTextAsync(path, json);

        return value;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var students = await GetAllAsync(p => p.Id > 0);
        var student = students.FirstOrDefault(p => p.Id == id);

        if (student is null)
            return false;

        students.Remove(student);

        var json = JsonConvert.SerializeObject(students, Formatting.Indented);
        await File.WriteAllTextAsync(path, json);
        return true;
    }

    public async Task<List<TResult>> GetAllAsync()
    {
        var models = await File.ReadAllTextAsync(path);
        if (string.IsNullOrEmpty(models))
            models = "[]";
        var json = JsonConvert.DeserializeObject<List<TResult>>(models);
        return json;
    }

    public async Task<TResult> GetByIdAsync(long id)
    {
        var students = await GetAllAsync(p => p.Id > 0);
        var student = students.FirstOrDefault(p => p.Id == id);
        if (student is null)
            return null;
        return student;
    }

    public async Task<TResult> UpdateAsync(long id, TResult value)
    {
        var students = await GetAllAsync(p => p.Id > 0);
        var model = students.FirstOrDefault(p => p.Id == id);
        var index = students.IndexOf(model);

        students.Insert(index, value);
        var json = JsonConvert.SerializeObject(students, Formatting.Indented);
        await File.WriteAllTextAsync(path, json);

        return value;
    }
}
