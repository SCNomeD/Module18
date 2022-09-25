namespace Module18._2
{
    /// <summary>
    /// Общий интерфейс команд
    /// </summary>
    interface IAction
    {
        void Run();
        void Undo();
    }
}
