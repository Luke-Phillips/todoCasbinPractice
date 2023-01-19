using NetCasbin;

namespace CasbinShtuff
{
    public class CasbinShtuff
    {
        public async Task DoCasbinShtuff()
        {
            var enforcer = new Enforcer("path/to/model.conf", "path/to/policy.csv");

            ////

            var sub = "alice";  // the user that wants to access a resource.
            var obj = "data1";  // the resource that is going to be accessed.
            var act = "read";  // the operation that the user performs on the resource.

            if (await enforcer.EnforceAsync(sub, obj, act)) 
            {
                // permit alice to read data1
            }
            else
            {
                // deny the request, show an error
            }

            ////

            var roles = enforcer.GetRolesForUser("alice");
        }

    }
}