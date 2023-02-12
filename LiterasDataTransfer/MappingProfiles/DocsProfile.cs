﻿using AutoMapper;
using LiterasData.Entities;
using LiterasDataTransfer.Dto;

namespace LiterasDataTransfer.MappingProfiles;

public class DocsProfile : Profile
{
    public DocsProfile()
    {
        CreateMap<Doc, DocDto>()
            .ForMember(doc => doc.Id, opt => opt.MapFrom(ent => ent.Id))
            .ForMember(doc => doc.CreatorId, opt => opt.MapFrom(ent => ent.CreatorId))
            .ForMember(doc => doc.Title, opt => opt.MapFrom(ent => ent.Title))
            .ForMember(doc => doc.Content, opt => opt.MapFrom(ent => ent.Content));

        CreateMap<DocDto, Doc>()
            .ForMember(doc => doc.Id, opt => opt.MapFrom(dto => dto.Id))
            .ForMember(doc => doc.CreatorId, opt => opt.MapFrom(dto => dto.CreatorId))
            .ForMember(doc => doc.Title, opt => opt.MapFrom(dto => dto.Title))
            .ForMember(doc => doc.Content, opt => opt.MapFrom(dto => dto.Content));
    }
}