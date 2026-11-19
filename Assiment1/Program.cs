using System.Numerics;
using System.Timers;

namespace Assiment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //variable of type object.Print it.
            //Book book1 = new Book();
            //object obj1 = book1;
            //book1.Title = "sports";
            //book1.Pages = 100;
            //Console.WriteLine(obj1);

            #endregion
            #region Question2
            // Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            //itself), GetHashCode(), and GetType() on book
            //Console.WriteLine(obj1.ToString());
            //Console.WriteLine(obj1.Equals(obj1));
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj1.GetType());
            #endregion
            #region Question3
            // Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";

            //compiler error
            int pages = int.Parse("464");
            #endregion

        }
    }
}
