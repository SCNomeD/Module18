using System.Text;

namespace Module18._2
{
    #region Program
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");
    //    }
    //}
    #endregion
    // Другие популярные поведенческие паттерны
    #region КОМАНДА (COMMAND)
    ///// <summary>
    ///// Базовый класс команды
    ///// </summary>
    //abstract class Command
    //{
    //    public abstract void Run();
    //    public abstract void Cancel();
    //}

    ///// <summary>
    ///// Конкретная реализация команды.
    ///// </summary>
    //class CommandOne : Command
    //{
    //    Receiver receiver;

    //    public CommandOne(Receiver receiver)
    //    {
    //        this.receiver = receiver;
    //    }

    //    // Выполнить
    //    public override void Run()
    //    {
    //        Console.WriteLine("Команда отправлена");
    //        receiver.Operation();
    //    }

    //    // Отменить
    //    public override void Cancel()
    //    { }
    //}

    ///// <summary>
    ///// Адресат команды
    ///// </summary>
    //class Receiver
    //{
    //    public void Operation()
    //    {
    //        Console.WriteLine("Процесс запущен");
    //    }
    //}

    ///// <summary>
    ///// Отправитель команды
    ///// </summary>
    //class Sender
    //{
    //    Command _command;

    //    public void SetCommand(Command command)
    //    {
    //        _command = command;
    //    }

    //    // Выполнить
    //    public void Run()
    //    {
    //        _command.Run();
    //    }

    //    // Отменить
    //    public void Cancel()
    //    {
    //        _command.Cancel();
    //    }
    //}

    ///// <summary>
    ///// Клиентский код
    ///// </summary>
    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.OutputEncoding = Encoding.UTF8;

    //        // создадим отправителя 
    //        var sender = new Sender();

    //        // создадим получателя 
    //        var receiver = new Receiver();

    //        // создадим команду 
    //        var commandOne = new CommandOne(receiver);

    //        // инициализация команды
    //        sender.SetCommand(commandOne);

    //        //  выполнение
    //        sender.Run();
    //    }
    //}
    #endregion
    #region СТРАТЕГИЯ (STRATEGY)
    ///// <summary>
    ///// Общий интерфейс некоего алгоритма
    ///// </summary>
    //public interface IStrategy
    //{
    //    void Algorithm();
    //}

    ///// <summary>
    ///// Первая реализация алгоритма
    ///// </summary>
    //public class StrategyOne : IStrategy
    //{
    //    public void Algorithm()
    //    { }
    //}

    ///// <summary>
    ///// Вторая реализация алгоритма
    ///// </summary>
    //public class StrategyTwo : IStrategy
    //{
    //    public void Algorithm()
    //    { }
    //}

    ///// <summary>
    ///// Клиентский код
    ///// </summary>
    //public class Client
    //{
    //    public IStrategy ClientStrategy { get; set; }

    //    public Client(IStrategy strategy)
    //    {
    //        ClientStrategy = strategy;
    //    }

    //    // Ds 
    //    public void ExecuteAlgorithm()
    //    {
    //        ClientStrategy.Algorithm();
    //    }
    //}
    #endregion
    #region 18.2.4
    /// <summary>
    ///  Клиентский код
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();
        }
    }
    #endregion
}