using Envoy.CustomRegistrar.Core.Models;

namespace Envoy.CustomRegistrar.Core.Services
{
    public interface IUserService
    {
        void Register(User user);
    }
}