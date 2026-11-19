namespace Assiment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //variable of type object.Print it.
            Book book1 = new Book();
            object obj1 = book1;
            book1.Title = "sports";
            book1.Pages = 100;
            Console.WriteLine(obj1);
            //Console.WriteLine($"{book1.title},{book1.page}");
            #endregion
        }
    }
}
