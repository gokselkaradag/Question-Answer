using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionProject.BusinessLayer.Abstract;
using QuestionProject.EntityLayer.Concrete;

namespace QuestionProject.WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public IActionResult QuestionList()
        {
            var values = _questionService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddQuesiton(Question question)
        {
            _questionService.TInsert(question);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteQuesiton(int id)
        {
            var values = _questionService.TGetById(id);
            _questionService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateQuestion(Question question)
        {
            _questionService.TUpdate(question);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetQuesiton(int id)
        {
            var values = _questionService.TGetById(id);
            return Ok(values);
        }
    }
}
