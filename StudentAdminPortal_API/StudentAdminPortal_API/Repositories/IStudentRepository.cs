using StudentAdminPortal_API.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal_API.Repositories
{ 
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
