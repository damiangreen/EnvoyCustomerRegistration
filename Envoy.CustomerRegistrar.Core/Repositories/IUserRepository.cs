using Envoy.CustomRegistrar.Core.Models;

namespace Envoy.CustomRegistrar.Core.Repositories
{
    public interface IUserRepository
    {
         void Register(User user);
    }
}