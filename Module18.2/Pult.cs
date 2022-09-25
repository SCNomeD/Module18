namespace Module18._2
{
    /// <summary>
    /// Отправитель команд
    /// </summary>
    class Pult
    {
        IAction _action;

        /// <summary>
        ///  Инициализация команды
        /// </summary>
        public void SetAction(IAction action)
        {
            _action = action;
        }

        public void OpenButton()
        {
            // запуск команды
            _action.Run();
        }

        public void CloseButton()
        {
            // отмена команды
            _action.Undo();
        }
    }
}
