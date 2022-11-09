using AutoMapper;
using Study.Core.Books;

namespace Study.Core;

public class CoreApplicationAutoMapperProfile : Profile
{
    /// <summary>
    /// DTO和module映射
    /// </summary>
    public CoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
    }
}
