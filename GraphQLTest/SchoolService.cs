using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest
{
    public class SchoolService
    {
        [GraphQLMetadata("schools")]
        public IList<School> GetLists()
        {
            return new List<School>() {
                new School{ Id = "No.1",Name = "西安1小" },
                new School{ Id = "No.2",Name = "西安2小" },
                new School{ Id = "No.3",Name = "西安3小" },
                new School{ Id = "No.4",Name = "西安4小" },
                new School{ Id = "No.5",Name = "西安5小" }
            };
        }

        [GraphQLMetadata("get")]
        public School Get(string id)
        {
            return GetLists().FirstOrDefault(a => a.Id == id);
        }

        [GraphQLMetadata("first")]
        public School First()
        {
            return GetLists().FirstOrDefault(a => a.Id == "No.1");
        }
    }
}
