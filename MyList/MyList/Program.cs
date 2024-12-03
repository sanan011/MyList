using MyList.Models;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new CustomList<string>();

            ListOperations<string>.AddOperation(myList, "Book");
            ListOperations<string>.AddOperation(myList, "Pen");
            ListOperations<string>.AddOperation(myList, "Notebook");

            ListOperations<string>.DisplayOperation(myList);

            ListOperations<string>.RemoveOperation(myList, "Pen");
            ListOperations<string>.DisplayOperation(myList);

            ListOperations<string>.RemoveOperation(myList, "Eraser");
        }
    }
}
