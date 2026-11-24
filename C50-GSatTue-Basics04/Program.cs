using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C50_GSatTue_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // 1]--------------------

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion

            #region Question 2
            // 2]--------------

            //int[,] shelfCopies = {
            //    { 3, 5 },
            //    { 1, 4 } };
            //Console.WriteLine(shelfCopies[1,0]);



            #endregion

            #region Question 3
            // 3]-------------

            //PrintWelcomeMessage();

            #endregion

            #region Question 4
            // 4]---------------

            //PrintBookTitle("System Architecture");

            #endregion

            #region Question 5
            // 5]--------------

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            //// pages will remain the same (400) because this is call by value for value type

            #endregion

            #region Question 6
            // 6]----------------'

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            //// prices[0] will change to 20.5 because array is reference type and will pass the address for the function

            #endregion

            #region Question 7
            // 7]-------------

            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            //// pages will change to 450 because the passing by reference for the value type 

            #endregion

            #region Question 8
            // 8]----------------

            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            ////prices will change because reassignment new array in the same reference of prices because calling by reference

            #endregion

            #region Question 9
            // 9]------------------

            //TryGetPrice("Clean Code", out double price);
            //Console.WriteLine(price);

            #endregion

            #region Question 10
            // 10]--------------

            //PrintBookInfo("Clean Code");
            //PrintBookInfo("Clean Code",500);

            #endregion


            #region Question 11
            // 10]--------------

            //PrintBookInfo(pages : 150, title : "Clean Code");

            #endregion

            #region Question 12
            // 12]----------------

            PrintAllTitles("Clean Code", "System Architecture", "System Design");

            #endregion
        }

        #region Question 3 function
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion

        #region Question 4 function
        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}" );
        }

        #endregion

        #region Question 5 function
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        #endregion


        #region Question 6 function
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion

        #region Question 7 function
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        #endregion

        #region Question 8 function 
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion

        #region Question 9 function
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
        #endregion


        #region Question 10 function
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title of the book: {title}, Pages: {pages}");
        }
        #endregion

        #region Question 12 function
        static void PrintAllTitles(params string[] titles)
        {
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine($"{i+1}.{titles[i]}");
            }
        }

        #endregion

    }
}
