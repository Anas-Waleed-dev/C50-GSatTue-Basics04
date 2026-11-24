namespace Assignment_3
{
    internal class Program
    {
        //Question 3 
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        //Question 4
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title:  " + title);
        }
        //Question 5
        static void AddBounsPages(int pages)
        {
            pages += 50;
        }
        ////Question 6
        static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;

        }

        //// Question 7
        static void AddBounsPagesByref(ref int pages)
        {
            pages += 50;
        }

        ////Question 8
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        ////Question 9
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        ////Question 10 ,11
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine("Pages: " + pages);
        }
        ////Question 12
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
        static void Main(string[] args)
        {
            #region Question 1
            //1.Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print 
            //the second price(index 1).
            //double[] prices = new double[] { 25.5, 40.0, 33.75 };
            //Console.WriteLine($"index 1: {prices[1]}");
            #endregion

            #region Question 2
            //2.Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and 
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine($"Number of copies[1,0]: {shelfCopies[1, 0]}");


            #endregion
            #region Question 3
            //3.Write a method called PrintWelcomeMessage that takes no parameters and prints 
            // "Welcome to the Library!".Call it from Main.
            // PrintWelcomeMessage();

            #endregion

            #region Question 4
            ////4.Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with 
            ////"Clean Code".
            //PrintBookTitle("Clean Code");
            #endregion

            #region Question 5
            //5.Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable 
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //AddBounsPages(pages);
            //Console.WriteLine(pages);//Out: 400 because the method changes inside don't affect the Original. 

            #endregion
            #region Question 6
            //6.Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it 
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]);//out =20.5 / because the array is reference is created for the same object in the heap same place the original array.

            #endregion

        }
    }
}
