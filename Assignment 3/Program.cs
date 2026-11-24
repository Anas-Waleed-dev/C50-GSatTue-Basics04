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
            
        }
    }
}
