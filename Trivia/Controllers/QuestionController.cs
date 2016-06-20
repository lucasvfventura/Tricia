using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Trivia.Infrastructure.Repositories.Abstract;
using Trivia.Models;
using Trivia.ViewModels;
using System.Collections.Generic;

namespace Trivia.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private IQuestionRepository qRepository;
        private IAnswerRepository aRepository;

        public QuestionController(IQuestionRepository qRepository, IAnswerRepository aRepository)
        {
            this.qRepository = qRepository;
            this.aRepository = aRepository;
        }

        public IEnumerable<QuestionViewModel> Get()
        {
            var questions = qRepository.GetAll();
            return Mapper.Map<IEnumerable<Question>, IEnumerable<QuestionViewModel>>(questions);
        }

        [HttpGet("random")]
        public QuestionViewModel Random()
        {
            var question = qRepository.GetRandom();
            return Mapper.Map<Question, QuestionViewModel>(question);
        }

        public IActionResult Post()
        {
            ViewData["Message"] = "Your contact page.";

            return null;
        }

        public IActionResult Error()
        {
            return null;
        }
    }
}
