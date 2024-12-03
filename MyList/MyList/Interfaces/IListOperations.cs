namespace MyList.Interfaces
{
    public interface IListOperations<T>
    {
        void Add(T item);
        void Remove(T item);
        void Display();
    }
}
