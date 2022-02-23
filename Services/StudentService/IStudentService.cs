using System.Collections.Generic;
using TE19DWEBAPIKURS.Models;

namespace TE19DWEBAPIKURS.Services.StudentService
{
    public interface IStudentService
    {
        List<Student> GetStudentList();
    }
}