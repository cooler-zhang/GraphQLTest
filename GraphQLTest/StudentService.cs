using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest
{
    public class StudentService
    {
        public IList<Student> GetLists()
        {
            return new List<Student>() {
                new Student{ Id = 1,Name = "张三1",Age = 18,SchoolId = 1 },
                new Student{ Id = 2,Name = "张三2",Age = 18,SchoolId = 3 },
                new Student{ Id = 3,Name = "张三3",Age = 18,SchoolId = 4 },
                new Student{ Id = 4,Name = "张三4",Age = 18,SchoolId = 2 },
                new Student{ Id = 5,Name = "张三5",Age = 18,SchoolId = 1 }
            };
        }

        public Student Get(int id)
        {
            return GetLists().FirstOrDefault(a => a.Id == id);
        }
    }
}
