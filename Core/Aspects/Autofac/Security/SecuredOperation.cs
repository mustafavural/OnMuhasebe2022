using Castle.DynamicProxy;
using Core.Business.Constants;
using Core.Extensions;
using Core.Utilities.Interceptors.Autofac;
using Core.Utilities.Ioc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Principal;

namespace Core.Aspects.Autofac.Security
{
    public class SecuredOperation : MethodInterception
    {
        private readonly string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;
        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var user = httpContext.User;
            var roleClaims = user.ClaimRoles();
            //Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("mustafa", "Admin"), _roles);
            Thread.CurrentPrincipal = new GenericPrincipal(user.Identity, roleClaims.ToArray());
            IPrincipal principal = Thread.CurrentPrincipal;

            foreach (var role in _roles)
            {
                if (principal.IsInRole(role))
                {
                    return;
                }
            }
            throw new System.Exception(CoreMessages.Authorization.AuthorizationDenied);
        }
    }
}