namespace TaskFromResultOverTaskRun
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var service = new SomeService();
            var result = await service.GetMultipliedValueAsync(3);
            var result2 = await service.GetMultipliedValueAsync2(3);
            var result3 = await service.GetMultipliedValueAsync3(3);

            Console.WriteLine($"The results are: {result}, {result2}, {result3}");
        }
    }
}
