﻿using AutoMapper;
using LiterasData.Entities;
using LiterasDataTransfer.DTO;

namespace LiterasDataTransfer.MappingProfiles;

public class DocumentsProfile : Profile
{
    public DocumentsProfile()
    {
        CreateMap<Document, DocumentDTO>()
            .ForMember(doc => doc.Id, opt => opt.MapFrom(ent => ent.Id))
            .ForMember(doc => doc.CreatorId, opt => opt.MapFrom(ent => ent.CreatorId))
            .ForMember(doc => doc.Title, opt => opt.MapFrom(ent => ent.Title))
            .ForMember(doc => doc.Content, opt => opt.MapFrom(ent => ent.Content));

        CreateMap<DocumentDTO, Document>()
            .ForMember(doc => doc.Id, opt => opt.MapFrom(dto => dto.Id))
            .ForMember(doc => doc.CreatorId, opt => opt.MapFrom(dto => dto.CreatorId))
            .ForMember(doc => doc.Title, opt => opt.MapFrom(dto => dto.Title))
            .ForMember(doc => doc.Content, opt => opt.MapFrom(dto => dto.Content));
    }
}