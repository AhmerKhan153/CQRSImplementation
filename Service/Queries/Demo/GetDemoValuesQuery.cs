using Core.Query;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Queries.Demo
{
    public class GetDemoValuesQuery : IQuery<List<GetDemoValuesQueryDTO>>
    {
        public string name { get; set; }

        public GetDemoValuesQuery(string Name) {

            name = Name;

        }
    }
}
