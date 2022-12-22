using Castle.DynamicProxy;
using Core.Business.Constants;
using Core.Extensions;
using Core.Utilities.Interceptors.Autofac;
using Core.Utilities.Security.JWT;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

namespace Core.Aspects.Autofac.Security
{
    public class SecuredOperation : MethodInterception
    {
        private readonly string[] _roles;
        private readonly TokenOptions _tokenOptions;
        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _tokenOptions = new TokenOptions();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            JwtSecurityToken token;
            ClaimsPrincipal user = new();
            List<string> roleClaims;
            if (UserHelper.AccessToken != null && UserHelper.AccessToken.Expiration > DateTime.Now )
            {
                token = new JwtSecurityTokenHandler().ReadJwtToken(UserHelper.AccessToken.Token);
                UserHelper.AccessToken.Expiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
                user = new ClaimsPrincipal(new ClaimsIdentity(token.Claims));
                roleClaims = user?.ClaimRoles();
                if (roleClaims.Count > 0)
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(user.Identity, roleClaims.ToArray());
                }
                else
                    throw new UnauthorizedAccessException(CoreMessages.AuthorizationMessages.UserHasNoClaims);
            }
            else
                throw new TimeoutException(CoreMessages.AuthorizationMessages.TokenIsTooOld);

            IPrincipal principal = Thread.CurrentPrincipal;
            foreach (var role in _roles)
            {
                if (principal.IsInRole(role))
                {
                    return;
                }
            }
            throw new UnauthorizedAccessException(CoreMessages.AuthorizationMessages.AuthorizationDenied);
        }
    }
}