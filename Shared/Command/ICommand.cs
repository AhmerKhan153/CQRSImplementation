using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace Core.Command
{
    public interface ICommand
    {
    }

    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Result Handle(TCommand query);
    }
}
