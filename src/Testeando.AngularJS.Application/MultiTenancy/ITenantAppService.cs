﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Testeando.AngularJS.MultiTenancy.Dto;

namespace Testeando.AngularJS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
