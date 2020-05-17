using Core.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Commands
{
    public class PostValuesCommand : ICommand
    {
        public string name { get; set; }
        public int valueType { get; set; }

        public PostValuesCommand(string Name, int ValueType)
        {
            this.name = Name;
            this.valueType = valueType;
        }

    }
}
