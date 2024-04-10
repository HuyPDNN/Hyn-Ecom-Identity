using AutoMapper;
using HynEcom.IdentityServer.EntityFrameworkCore.Entities;

namespace HynEcom.IdentityServer.Models
{
    public class ApplicationAutoMapperProfile : Profile
    {
        public ApplicationAutoMapperProfile()
        {
            CreateMap<BusinessObjectRequest, BusinessObject>();
            CreateMap<BusinessObject, BusinessObjectResponse>();
        }
    }
}
