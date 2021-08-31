using DemoLibrary;

namespace ConsoleUI
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMailer());
        }

        public static IMessageSender CreateMailer()
        {
            return new Texter();
        }
        
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
