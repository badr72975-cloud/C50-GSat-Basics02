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
            #region Question4
            //Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block
            //try
            //{
            //    int x = 10, y = 0;
            //    int z = x / y;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally { Console.WriteLine("Done"); }
            #endregion
            #region Question5
            //Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
            //int Pages = 300;
            //double x = pages;
            #endregion
            #region Question5
            //Q06. Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int x = (int)price;

            #endregion

        }
    }
}
