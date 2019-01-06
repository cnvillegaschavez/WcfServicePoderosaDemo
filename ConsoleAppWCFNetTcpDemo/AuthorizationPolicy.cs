using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.IdentityModel.Policy;
using System.Security.Principal;

namespace ConsoleAppWCFNetTcpDemo
{
    public class AuthorizationPolicy: IAuthorizationPolicy
    {
        Guid _id = Guid.NewGuid();

        public ClaimSet Issuer
        {
            get
            {
                return ClaimSet.System;
            }
        }

        public string Id => _id.ToString();

        public bool Evaluate(EvaluationContext evaluationContext, ref object state)
        {
            IIdentity client = GetClientIDentity(evaluationContext);
            evaluationContext.Properties["Principal"] = new CustomPrincipal(client);
            return true;
        }

        private IIdentity GetClientIDentity(EvaluationContext evaluationContext)
        {
            object obj;
            if(!evaluationContext.Properties.TryGetValue("Identities", out obj))
            {
                throw new Exception("No se encontro la identidad");
            }

            IList<IIdentity> identities = obj as IList<IIdentity>;
            if (identities == null || identities.Count <= 0)
                throw new Exception("No Identity found");

            return identities[0];
        }
    }
}
