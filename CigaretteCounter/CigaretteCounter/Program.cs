namespace CigaretteCounter
{
    internal class Program
    {
        static void Main()
        {

            List<int> CigAmount = new List<int>();

            Cigarette cigCounter = new Cigarette(0, 0);

            while (true)
            {
                Console.WriteLine("Choose an option:\n" +
                                  "1. Add cigarette\n" +
                                  "2. See total cigarettes\n" +
                                  "3. See progression" +
                                  "4. Exit");
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter number of cigs to add:");
                        string cigNum = Console.ReadLine();
                        int cigNumInt = Int32.Parse(cigNum);
                        CigAmount.Add(cigNumInt);
                        cigCounter.TotalCigs += cigNumInt;
                        Console.WriteLine($"You now have smoked {cigCounter.TotalCigs} cigarettes in total.");
                        break;
                   

                }



            }
        }
    }
}
