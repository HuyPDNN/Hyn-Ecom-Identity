﻿namespace HynEcom.IdentityServer.Models
{
    public interface IBusinessObjectService
    {
        Task<BusinessObjectResponse> CreateAsync(BusinessObjectRequest request);
        Task<List<BusinessObjectResponse>> GetAllAsync(PagedResultRequest request);
        //Task<BusinessObjectResponse> UpdateAsync(BusinessObjectRequest request);
        //Task<BusinessObjectResponse> DeleteAsync(string id);
    }
}
