
using EntitiesClasses.Entities;
using ViewModel.ViewModels.UserViewModel;
using ViewModels.AudioDetailViewModel;
using ViewModels.BookDetails;
using ViewModels.CommonViewModel;
using ViewModels.FarqaCategoryViewModel;
using ViewModels.MonthlyMagizne;
using ViewModels.NewsViewModel;
using ViewModels.ScholarViewModel;
using static ViewModels.MessageChatViewModel.MessageDto;

namespace ViewModel.AutoMapper;
public class AutoMappers : Profile
    {
    public AutoMappers()
    {
        CreateMap<BookCategory, CommonDto>().ReverseMap();
        CreateMap<BookCategory, CommonDto>().ReverseMap();
        CreateMap<MonthlyMagzine, CommonDto>().ReverseMap();
        CreateMap<FarqaCategory, FarqaCategoryDto>().ReverseMap();
        CreateMap<FarqaCategory, FarqaCategorySaveDto>().ReverseMap();
        CreateMap<Scholar, ScholarDto>().ReverseMap();
        CreateMap<MonthlyMagzine, CommonDto>().ReverseMap();
        CreateMap<Scholar, ScholarSaveDto>().ReverseMap();
        CreateMap<MonthlyMagzine, MonthlyMagzinesSaveDto>().ReverseMap(); 
        CreateMap<BookDetail, BookDetailDto>().ReverseMap();
        CreateMap<AudioScholars, CommonDto>().ReverseMap();
        CreateMap< AudioDetail, CommonDto> ().ReverseMap();
        CreateMap<UserTypes, UserTypesDto>().ReverseMap();
        CreateMap<News, NewsDto>().ReverseMap(); 
        CreateMap<User, UserListDto>().ReverseMap();
        CreateMap<AudioDetail, LikesorDislikesDto>().ReverseMap();
        CreateMap<Message, MessageForAddDto>().ReverseMap();
        CreateMap<Message, GetMessagesDto>().ReverseMap();
        
        CreateMap<MadrassaClass, CommonDto>().ReverseMap();
        //CreateMap<BookDetail, BookDetailSaveDto>().ReverseMap(); 
        CreateMap<BookImage, BookImageDto>().ReverseMap();
        //CreateMap<BookImage, BookImageSaveDto>().ReverseMap(); 
        //CreateMap<User, UserListDto>()
        //       .ForMember(dest =>
        //       dest.Name,
        //       opt => opt.MapFrom(src => src.)).ReverseMap();
        CreateMap<BookCategory, CommonGetListDto>().ReverseMap();
        CreateMap<News, CommonGetListDto>().ReverseMap();
        CreateMap<AudioScholars, CommonGetListDto>().ReverseMap();
        CreateMap<AudioDetail, CommonGetListDto>().ReverseMap();
        CreateMap<MadrassaClass, CommonGetListDto>().ReverseMap();
        CreateMap<BookDetail, CommonGetListDto>().ReverseMap();
        CreateMap<BookImage, CommonGetListDto>().ReverseMap();  
         CreateMap<FarqaCategory, CommonGetListDto>().ReverseMap();
    }



}