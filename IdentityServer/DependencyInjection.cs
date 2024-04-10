using AutoMapper;
using HynEcom.IdentityServer.Models;

namespace HynEcom.IdentityServer.IdentityServer
{
    public class DependencyInjection
    {
        public static void RegisterDI(WebApplicationBuilder builder)
        {
            //AutoMapper
            builder.Services.AddSingleton<IMapper, Mapper>();

            //BusinessObject
            builder.Services.AddTransient<IBusinessObjectService, BusinessObjectService>();
        }
    }
}
