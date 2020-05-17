using Core.Command;
using CSharpFunctionalExtensions;
using Service.Model;
using Service.Repositories;
using System;

namespace Service.Commands.Handler
{
    public class PostValuesCommandHandler : ICommandHandler<PostValuesCommand>
    {
        ValuesRepository _valuesRepository;

        public PostValuesCommandHandler(ValuesRepository valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }

        public Result Handle(PostValuesCommand command)
        {
            _valuesRepository.AddValue(new Model.Values
            {
                Name = command.name,
                ValueType = (Types)command.valueType,
                CreatedDate = DateTime.Now,
            });
            return Result.Ok();
        }
    }
}
