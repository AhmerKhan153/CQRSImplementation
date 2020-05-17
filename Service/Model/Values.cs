using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Model
{
    public class Values
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public Types ValueType { get; set; }
    }

    public enum Types
    {
        Loren = 1,
        Ipsum = 2,
        Dolut = 3
    }

}
