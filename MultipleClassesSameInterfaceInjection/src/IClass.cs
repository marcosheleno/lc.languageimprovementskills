namespace GeneralTesting.MultipleClassesSameInterfaceInjection;

public interface IClass<T> where T : class
{
    public void Do();
}