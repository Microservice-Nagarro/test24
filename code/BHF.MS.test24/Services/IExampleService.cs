using BHF.MS.test24.Models;

namespace BHF.MS.test24.Services
{
    public interface IExampleService
    {
        Task<HttpResponseMessage> PostSomething(ExampleModel model);
        Task<HttpResponseMessage> GetSomething();
    }
}

