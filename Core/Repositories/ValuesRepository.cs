using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repositories
{
    public class ValuesRepository
    {
        public List<Values> GetAllValues()
        {
            return new List<Values>()
            {
                new Values{Id = 1,Name = "Alpha",CreatedDate = new DateTime(2019,12,2),ValueType = Types.Dolut },
                new Values{ Id = 2,Name = "Bravo",CreatedDate = new DateTime(2019,11,3),ValueType = Types.Ipsum },
                new Values{ Id = 3,Name = "Charlie",CreatedDate = new DateTime(2020,1,2),ValueType = Types.Loren },
                new Values{ Id = 4,Name = "Dark",CreatedDate = new DateTime(2020,1,20),ValueType = Types.Dolut },
                new Values{ Id = 5,Name = "Phoenix",CreatedDate = new DateTime(2019,5,12),ValueType = Types.Dolut },
                new Values{ Id = 6,Name = "Nuance",CreatedDate = new DateTime(2019,7,25),ValueType = Types.Ipsum },
                new Values{ Id = 7,Name = "Berlin",CreatedDate = new DateTime(2019,2,2),ValueType = Types.Dolut },
                new Values{ Id = 8,Name = "Grace",CreatedDate = new DateTime(2019,3,15),ValueType = Types.Dolut },

            };

        }
    }
}
