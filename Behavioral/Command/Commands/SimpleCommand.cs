using Command.Abstractions;
using System;

namespace Command.Commands
{
    public class SimpleCommand : ICommand
    {
        private readonly string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
        }
    }
}