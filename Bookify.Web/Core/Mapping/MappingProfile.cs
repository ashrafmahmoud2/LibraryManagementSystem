﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagementSystem.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Categories
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryFormViewModel, Category>().ReverseMap();
            CreateMap<Category, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));

            //Authors
            CreateMap<Author, AuthorViewModel>();
            CreateMap<AuthorFormViewModel, Author>().ReverseMap();
            CreateMap<Author, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));


            //Books

            CreateMap<Book, BookViewModel>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author!.Name))
                .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories.Select(c => c.Category!.Name).ToList()));


            CreateMap<BookFormViewModel, Book>()
                .ReverseMap()
                .ForMember(des => des.Categories, opt => opt.Ignore());

            CreateMap<Book, SelectListItem>().
               ForMember(dest => dest.Value, op => op.MapFrom(src => src.Id.ToString()))
                 .ForMember(dest => dest.Value, op => op.MapFrom(src => src.Title));


            //Book Copies
            CreateMap<BookCopy, BookCopyViewModel>().
                ForMember(des => des.BookTitle, opt => opt.MapFrom(sec => sec.Book!.Title));

            CreateMap<BookCopyFormViewModel, BookCopy>().ReverseMap();


            //Users
            CreateMap<ApplicationUser, UserViewModel>();
            CreateMap<UserFormViewModel, ApplicationUser>()
                .ForMember(des => des.NormalizedEmail, opt => opt.MapFrom(src => src.Email.ToUpper()))
                .ForMember(des => des.NormalizedUserName, opt => opt.MapFrom(src => src.UserName.ToUpper()))
                .ReverseMap();


            //Subscriber
            CreateMap<Subscriber, SubscriberFormViewModel>().ReverseMap();
            CreateMap<Subscriber, SubscriberSearchResultViewModel>()
              .ForMember(des => des.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            CreateMap<Subscriber, SubscriberDetailsFormViewModel>()
                .ForMember(des => des.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(des => des.Area, opt => opt.MapFrom(src => src.Area!.Name))
                .ForMember(des => des.Governorate, opt => opt.MapFrom(src => src.Governorate!.Name));


            //Areas /Governorate
            CreateMap<Governorate, SelectListItem>()
                 .ForMember(des => des.Value, opt => opt.MapFrom(src => src.Id))
                 .ForMember(des => des.Text, opt => opt.MapFrom(src => src.Name));

            CreateMap<Area, SelectListItem>()
             .ForMember(des => des.Value, opt => opt.MapFrom(src => src.Id))
             .ForMember(des => des.Text, opt => opt.MapFrom(src => src.Name));








        }
    }
}