using Envoy.CustomRegistrar.Core.Models;
using FluentNHibernate.Mapping;

namespace Envoy.CustomRegistrar.Core.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.Email);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.AddressLine1);
            Map(x => x.AddressLine2); 
        }
    }
}
