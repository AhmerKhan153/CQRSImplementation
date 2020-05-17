using Core.Command;
using Core.Query;
using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Transmitter
{
    public sealed class Transmitter
    {
        private readonly IServiceProvider _service;

        public Transmitter(IServiceProvider service)
        {
            _service = service;
        }


        public Result Transmit(ICommand command)
        {
            Type type = typeof(ICommandHandler<>);
            Type[] typeArgs = { command.GetType() };
            Type handlerType = type.MakeGenericType(typeArgs);
            dynamic handler = _service.GetService(handlerType);
            Result result = handler.Handle((dynamic)command);
            return result;
        }

        public T Transmit<T>(IQuery<T> query)
        {
            Type type = typeof(IQueryHandler<,>);
            Type[] typeArgs = { query.GetType(), typeof(T) };
            Type handlerType = type.MakeGenericType(typeArgs);
            dynamic handler = _service.GetService(handlerType);
            dynamic result = handler.Handle((dynamic)query);
            return result;
        }
    }
}
