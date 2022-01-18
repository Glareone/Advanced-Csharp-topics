namespace OnceAsyncAlwaysAsync
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var repository = new Repository();

            // incorrect way of calling the async endpoint from sync context
            var number = repository.GetValueAsync().Result;

            // In .Net 5 most of basics could use Async and Task.
            // Even Main in console application
            var number_result = await repository.GetValueAsync();

            Console.WriteLine($"The number is {number} and {number_result}");
        }
    }

    public class Repository
    {

        public async Task<int> GetValueAsync()
        {
            var random = new Random();

            return await Task.FromResult(random.Next(0, 100));
        }
    }
}
