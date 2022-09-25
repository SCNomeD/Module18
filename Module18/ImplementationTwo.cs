namespace Module18
{
    /// <summary>
    /// Первая реализация прототипа
    /// </summary>
    class ImplementationTwo : BaseClass
    {
        public ImplementationTwo(int id) : base(id)
        { }

        public override BaseClass Clone()
        {
            return new ImplementationTwo(Id);
        }
    }
}
