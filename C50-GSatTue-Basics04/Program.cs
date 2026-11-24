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

            PrintBookTitle("System Architecture");

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



    }
}
