using System;
using System.Threading.Tasks;

namespace UsingAndDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceRegistry reg = new ServiceRegistry();
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
            // "The using statement ensures that Dispose (or DisposeAsync) is called even if an exception occurs within the using block."


            using (CustomerService custSvc = reg.GetCusomterService())
            {
                // Dispose method is not called when debugging in VS
                // but is called when we run the console app without VS!!!!
                // EXPLANATION: https://stackoverflow.com/questions/49106975/why-using-does-not-call-dispose-method-in-debugger
                // https://docs.microsoft.com/en-us/visualstudio/debugger/managing-exceptions-with-the-debugger?view=vs-2022
                // it does not help here: https://docs.microsoft.com/en-us/visualstudio/debugger/managing-exceptions-with-the-debugger?view=vs-2022#BKMK_UserUnhandled
                // throw new Exception("Fail!!!");
            }


            MainAsync().GetAwaiter().GetResult();

            Console.WriteLine("END");
            Console.ReadKey();
        }

        private static async Task MainAsync()
        {
            ServiceRegistry reg = new ServiceRegistry();
            using (CustomerService custSvc = await reg.GetCusomterServiceAsync())
            {

            }
        }
    }
}
