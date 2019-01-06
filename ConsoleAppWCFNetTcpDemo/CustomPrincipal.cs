using System.Linq;
using System.Security.Principal;

namespace ConsoleAppWCFNetTcpDemo
{
    internal class CustomPrincipal: IPrincipal
    {
        private IIdentity _identity;
        string[] _roles;
        public CustomPrincipal(IIdentity identity)
        {
            this._identity = identity;
        }

        public IIdentity Identity => _identity;

        public bool IsInRole(string role)
        {
            EnsureRoles();
            return _roles.Contains(role);
        }

        protected virtual void EnsureRoles()
        {
            if (_identity.Name == "admin")
                _roles = new string[1] { "admin" };
            else
                _roles = new string[1] { "user" };
        }
    }
}