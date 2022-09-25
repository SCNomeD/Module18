namespace Module18
{
    /// <summary>
    /// Первая реализация прототипа
    /// </summary>
    class ImplementationOne : BaseClass
    {
        public ImplementationOne(int id) : base(id)
        { }

        public override BaseClass Clone()
        {
            return new ImplementationOne(Id);
        }
    }
}
