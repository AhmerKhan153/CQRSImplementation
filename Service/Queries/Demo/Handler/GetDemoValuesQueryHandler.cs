using Core.Query;
using Service.DTO;
using Service.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Service.Queries.Demo.Handler
{
    public class GetDemoValuesQueryHandler : IQueryHandler<GetDemoValuesQuery, List<GetDemoValuesQueryDTO>>
    {
        ValuesRepository _valuesRepository;

        public GetDemoValuesQueryHandler(ValuesRepository valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }

        public List<GetDemoValuesQueryDTO> Handle(GetDemoValuesQuery query)
        {
            var result = _valuesRepository.GetAllValues().Where(z => z.Name == query.name).Select(z => new GetDemoValuesQueryDTO { Id = z.Id, Name = z.Name }).ToList();
            return result;

        }
    }
}
