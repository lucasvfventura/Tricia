using AutoMapper;
using Trivia.Models;
using Trivia.ViewModels;

namespace Trivia.Infrastructure.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Question, QuestionViewModel>();
            Mapper.CreateMap<QuestionViewModel, Question>();

            Mapper.CreateMap<Answer, AnswerViewModel>();
            Mapper.CreateMap<AnswerViewModel, Answer>();
        }
    }
}
