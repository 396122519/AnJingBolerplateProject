using Abp.MultiTenancy;
using AnJingBolerplateProject.Authorization.Users;

namespace AnJingBolerplateProject.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
