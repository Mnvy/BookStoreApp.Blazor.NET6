using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Author;
using BookStoreApp.API.Models.Books;

namespace BookStoreApp.API.Configuratios
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            CreateMap<Book, BooksReadOnlyDto>()
                .ForMember(q => q.AuthorName, d =>d.MapFrom(map => $"{map.Author.Firstname}{map.Author.Lastname}"))
                .ReverseMap();
            CreateMap<BooksCreateDto, Book>().ReverseMap();
            CreateMap<BooksUpdateDto, Book>().ReverseMap();

        }
    }
}
