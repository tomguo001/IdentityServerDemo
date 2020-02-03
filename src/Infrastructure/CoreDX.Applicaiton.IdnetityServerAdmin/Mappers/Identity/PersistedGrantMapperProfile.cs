﻿using AutoMapper;
using IdentityServer4.EntityFramework.Entities;
using Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Grant;
using Skoruba.IdentityServer4.Admin.EntityFramework.Entities;
using Skoruba.IdentityServer4.Admin.EntityFramework.Extensions.Common;

namespace CoreDX.Applicaiton.IdnetityServerAdmin.Mappers.Identity
{
    public class PersistedGrantMapperProfile : Profile
    {
        public PersistedGrantMapperProfile()
        {
            // entity to model
            CreateMap<PersistedGrant, PersistedGrantDto>(MemberList.Destination)
                .ReverseMap();

            CreateMap<PersistedGrantDataView, PersistedGrantDto>(MemberList.Destination);

            CreateMap<PagedList<PersistedGrantDataView>, PersistedGrantsDto>(MemberList.Destination)
                .ForMember(x => x.PersistedGrants,
                    opt => opt.MapFrom(src => src.Data));

            CreateMap<PagedList<PersistedGrant>, PersistedGrantsDto>(MemberList.Destination)
                .ForMember(x => x.PersistedGrants,
                    opt => opt.MapFrom(src => src.Data));
        }
    }
}
