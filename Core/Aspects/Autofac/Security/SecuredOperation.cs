using Castle.DynamicProxy;
using Core.Business.Constants;
using Core.Extensions;
using Core.Utilities.Interceptors.Autofac;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

namespace Core.Aspects.Autofac.Security
{
    public class SecuredOperation : MethodInterception
    {
        private readonly string[] _roles;
        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var token = new JwtSecurityTokenHandler().ReadJwtToken(UserHelper.AccessToken.Token);
            var user = new ClaimsPrincipal(new ClaimsIdentity(token.Claims));
            var roleClaims = user.ClaimRoles();
            Thread.CurrentPrincipal = new GenericPrincipal(user.Identity, roleClaims.ToArray());
            IPrincipal principal = Thread.CurrentPrincipal;

            foreach (var role in _roles)
            {
                if (principal.IsInRole(role))
                {
                    return;
                }
            }
            throw new UnauthorizedAccessException(CoreMessages.Authorization.AuthorizationDenied);
        }
    }
}