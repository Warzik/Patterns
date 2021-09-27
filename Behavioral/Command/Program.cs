using Command.Commands;

namespace Command
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            var receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}