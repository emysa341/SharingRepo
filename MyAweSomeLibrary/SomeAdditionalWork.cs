using System;
using System.Threading.Tasks;

namespace MyAweSomeLibrary
{
    public class SomeAdditionalWork
    {
        public  async Task<string> SomeActionAsync()
        {
            await Task.Delay(10);

            return "WorkDone";
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}