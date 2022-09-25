using System.Text;

namespace Module18
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
    // Другие популярные порождающие паттерны
    #region СТРОИТЕЛЬ (BUILDER)
    //class Client
    //{
    //    void Main()
    //    {
    //        Console.OutputEncoding = Encoding.UTF8;

    //        // инициализация строителя
    //        IBuilder builder = new ProductBuilder();

    //        // Создаем менеджера, который будет рулить процессом
    //        BuildManager buildManager = new BuildManager(builder);

    //        //  Стартуем и получаем результат
    //        buildManager.StartBuildingProcess();

    //        Product product = builder.GetBuildingResult();
    //    }
    //}

    ///// <summary>
    ///// Объект, инкапсулирующий процесс строительства
    ///// </summary>
    //class BuildManager
    //{
    //    IBuilder Builder;
    //    public BuildManager(IBuilder builder)
    //    {
    //        Builder = builder;
    //    }
    //    public void StartBuildingProcess()
    //    {
    //        Builder.FirstStage();
    //        Builder.SecondStage();
    //        Builder.ThirdStage();
    //    }
    //}

    ///// <summary>
    ///// Абстрактный интерфейс строителя
    ///// </summary>
    //interface IBuilder
    //{
    //    void FirstStage();
    //    void SecondStage();
    //    void ThirdStage();
    //    Product GetBuildingResult();
    //}

    ///// <summary>
    ///// Реализация продукта - сложного объекта
    ///// </summary>
    //class Product
    //{
    //    List<object> parts = new List<object>();

    //    /// Метод для поэтапного процесса создания
    //    public void Add(string part)
    //    {
    //        parts.Add(part);
    //    }
    //}

    ///// <summary>
    /////  Реализация строителя конкретного продукта
    ///// </summary>
    //class ProductBuilder : IBuilder
    //{
    //    Product product = new Product();

    //    // 1-й этап 
    //    public void FirstStage()
    //    {
    //        product.Add("Part one");
    //    }

    //    // 2-й этап 
    //    public void SecondStage()
    //    {
    //        product.Add("Part two");
    //    }

    //    // 3-й этап 
    //    public void ThirdStage()
    //    {
    //        product.Add("Part three");
    //    }

    //    // 4-й этап 
    //    public Product GetBuildingResult()
    //    {
    //        return product;
    //    }
    //}
    #endregion
    #region 18.1.1
    //class Client
    //{
    //    /// <summary>
    //    /// Клиентский код
    //    /// </summary>
    //    public static void Main()
    //    {
    //        Console.OutputEncoding = Encoding.UTF8;

    //        // Объект завода, который будет заниматься производством
    //        var carPlant = new CarPlant();

    //        // производство скутеров
    //        Conveyor builder = new ScooterConveyor();
    //        carPlant.Construct(builder);
    //        builder.Product.Show();

    //        // производство автомобилей
    //        builder = new CarConveyor();
    //        carPlant.Construct(builder);
    //        builder.Product.Show();

    //        // производство мотоциклов
    //        builder = new MotoConveyor();
    //        carPlant.Construct(builder);
    //        builder.Product.Show();
    //    }
    //}
    #endregion
    #region ПРОТОТИП (PROTOTYPE)
    ///// <summary>
    ///// Общий интерфейс для клонирования похожих объектов
    ///// </summary>
    //abstract class Prototype
    //{
    //    protected int Id;

    //    // Метод - конструктор
    //    public Prototype(int id)
    //    {
    //        Id = id;
    //    }

    //    // Метод для клонирования самого себя
    //    public abstract Prototype Clone();
    //}

    ///// <summary>
    /////  Первая конкретная реализация клонированного объекта
    ///// </summary>
    //class ClassOne : Prototype
    //{
    //    public ClassOne(int id) : base(id)
    //    { }

    //    public override Prototype Clone()
    //    {
    //        return new ClassOne(Id);
    //    }
    //}

    ///// <summary>
    ///// Вторая конкретная реализация клонированного объекта
    ///// </summary>
    //class ClassTwo : Prototype
    //{
    //    public ClassTwo(int id) : base(id)
    //    { }

    //    public override Prototype Clone()
    //    {
    //        return new ClassTwo(Id);
    //    }
    //}

    ///// <summary>
    ///// Клиентский код, использующий прототип
    ///// </summary>
    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.OutputEncoding = Encoding.UTF8;

    //        //  создаем первый конкретный объект по прототипу 
    //        Prototype prototype = new ClassOne(1);
    //        // Клонируем
    //        Prototype clone = prototype.Clone();

    //        //  создаем второй конкретный объект по прототипу 
    //        prototype = new ClassTwo(2);
    //        // Клонируем
    //        clone = prototype.Clone();
    //    }
    //}
    #endregion
    #region 18.1.5-18.1.6
    class Program
    {
        /// <summary>
        ///  Клиентский код
        /// </summary>
        static void Main()
        {
            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(2);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();
        }
    }
    #endregion
}