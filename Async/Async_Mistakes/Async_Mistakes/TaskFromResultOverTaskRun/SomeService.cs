namespace TaskFromResultOverTaskRun
{
    using System.Threading.Tasks;

    public class SomeService
    {
        public async Task<int> GetMultipliedValueAsync(int number)
        {
            return await Task.Run(() => number * 2);
        }

        public async Task<int> GetMultipliedValueAsync2(int number)
        {
            return await Task.FromResult(number * 2);
        }

        // In C# 7.0 ValueTask was added and it's advantage in not allocating object in a heap as an additional resources.
        public async ValueTask<int> GetMultipliedValueAsync3(int number)
        {
            return await new ValueTask<int>(number * 3);
        }
    }
}
