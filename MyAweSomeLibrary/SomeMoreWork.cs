using System;
using System.Threading.Tasks;

namespace MyAweSomeLibrary
{
    public class SomeWork : IDisposable
    {
        private SomeAdditionalWork _someAdditionalWork;

        public SomeWork(SomeAdditionalWork someAdditionalWork)
        {
            _someAdditionalWork = someAdditionalWork;
        }

        public async Task SomeAction()
        {
            await _someAdditionalWork.SomeActionAsync();
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
