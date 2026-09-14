using System.Text;

namespace Assiment4.String_And_Array
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Question 1
            // Create a one-dimensional array double[] prices
            // with values 25.5, 40.0, 33.75.
            // Print the second price (index 1).

            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion


            #region Question 2
            // Create a 2x2 multidimensional array int[,] shelfCopies.
            // Shelf 0 has: 3, 5
            // Shelf 1 has: 1, 4
            // Print the number of copies on shelf 1, slot 0.
            int [,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(shelfCopies[1,0]);

            #endregion


            #region Question 3
            // Write a method called PrintWelcomeMessage
            // that takes no parameters and prints:
            // "Welcome to the Library!"
            // Call it from Main.

            //PrintWelcomeMessage();

            #endregion


            #region Question 4
            // Write a method PrintBookTitle(string title)
            // that prints:
            // "Book title: " + title
            // Call it with "Clean Code".



            #endregion


            #region Question 5
            // Write a method AddBonusPages(int pages)
            // that adds 50 to pages.
            //
            // Create:
            // int pages = 400;
            //
            // Call the method and print pages afterward.
            //
            // Question:
            // What do you expect to see, and why?



            #endregion


            #region Question 6
            // Write a method ApplyDiscount(double[] prices)
            // that subtracts 5 from prices[0].
            //
            // Use:
            // double[] prices = { 25.5, 40.0 };
            //
            // Call the method and print prices[0] afterward.
            //
            // Question:
            // What do you expect to see, and why?



            #endregion


            #region Question 7
            // Rewrite Question 5 method as:
            // AddBonusPagesByRef(ref int pages)
            //
            // Use ref.
            // Call it and print pages afterward.
            //
            // Question:
            // How is the result different from Question 5?



            #endregion


            #region Question 8
            // Write a method:
            // ReplaceArray(ref double[] prices)
            //
            // It should replace prices entirely with:
            // { 10.0, 12.5, 15.0 }
            //
            // Call it with your prices array.
            // Print prices.Length afterward.



            #endregion


            // =========================
            // STRING QUESTIONS
            // =========================


            #region String Question 1
            // Declare:
            // string title = "clean code";
            //
            // Call title.ToUpper()
            // and store the result in a new variable upperTitle.
            //
            // Print both title and upperTitle
            // to show that title did not change.
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            #endregion


            #region String Question 2
            // Declare two separate string variables.
            // Set both to:
            // "Clean Code"
            //
            // Use ReferenceEquals()
            // to check if they point to the same object in memory.

            string str1 = "Clean Code";
            string str2 = "Clean Code";
            Console.WriteLine(ReferenceEquals(str1,str2));

            #endregion


            #region String Question 3
            // Create a StringBuilder.
            //
            // Append:
            // "Book List"
            //
            // Then append:
            // " - Updated"
            //
            // Print the final result.

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Book List");
            stringBuilder.Append(" - Updated");
            Console.WriteLine(stringBuilder);
            #endregion


            #region String Question 4
            // Using the StringBuilder from the previous question,
            // use Replace()
            // to change:
            // "Book List"
            //
            // into:
            // "Library"
            //
            // Print the result.
            stringBuilder.Replace("Book List", "Library");
            Console.WriteLine(stringBuilder);


            #endregion


            #region String Question 5
            // Given:
            // string title = "Clean Code";
            // int pages = 464;
            //
            // Build:
            // "Book: Clean Code, Pages: 464"
            //
            // using the + operator.

            string Title = "Clean Code";
            int pages = 464;
            Console.WriteLine("Book: "+Title+ ", Pages: "+pages);

            #endregion


            #region String Question 6
            // Build the same sentence:
            // "Book: Clean Code, Pages: 464"
            //
            // using string interpolation:
            // $"..."



            #endregion


            #region String Question 7
            // Build the same sentence again:
            // "Book: Clean Code, Pages: 464"
            //
            // using:
            // string.Format()



            #endregion
        }

        #region Methods

        // Question 3 method
        void PrintWelcomeMessage() {
            Console.WriteLine("Welcome to the Library!");
               }

        // Question 4 method


        // Question 5 method


        // Question 6 method


        // Question 7 method


        // Question 8 method


        #endregion
    }

}