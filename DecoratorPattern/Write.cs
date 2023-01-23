namespace DecoratorPattern
{
    public interface IWriter
    {
        void write();
    }
    public class Write : IWriter
    {
        public virtual void write()
        {
            Console.WriteLine("Hello World");
        }
    }

    // Inherite Model
    //public class AddDash : Write
    //{
    //    public override void write()
    //    {
    //        Console.WriteLine("----------");
    //        base.write();
    //        Console.WriteLine("----------");
    //    }
    //}

    public class AddDashDecorator : IWriter
    {
        private readonly IWriter _writer;
        public AddDashDecorator(IWriter writer)
        {
            _writer = writer;
        }

        public void write()
        {
            Console.WriteLine("----------");
            _writer.write();
            Console.WriteLine("----------");
        }
    }
    // Inherite Model

    //public class AddStar : AddDash
    //{
    //    public override void write()
    //    {
    //        Console.WriteLine("********");
    //        base.write();
    //        Console.WriteLine("********");
    //    }
    //}

    public class AddStarDecorator : IWriter
    {
        private readonly IWriter _writer;

        public AddStarDecorator(IWriter writer)
        {
            _writer = writer;
        }

        public void write()
        {
            Console.WriteLine("********");
            _writer.write();
            Console.WriteLine("********");
        }
    }
}
