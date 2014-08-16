using Envoy.CustomRegistrar.Core.Models;
using Envoy.CustomRegistrar.Core.Repositories;

namespace Envoy.CustomRegistrar.Core.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Register(User user)
        {
            _userRepository.Register(user);
        }
    }
}
