using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Principal;
using System.Threading;

namespace ConsoleAppWCFNetTcpDemo
{
    public class UserAuthentication : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == null || password == null)
                throw new SecurityTokenException("Username o password tiene valor null");
            string[] roles = { };
            if (userName == "admin" && password == "admin@1")
            {
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userName, "UserName"), roles);
            }
        }
    }
}
