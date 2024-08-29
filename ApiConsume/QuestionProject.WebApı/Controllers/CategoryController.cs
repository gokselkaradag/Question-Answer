﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionProject.BusinessLayer.Abstract;
using QuestionProject.EntityLayer.Concrete;

namespace QuestionProject.WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            _categoryService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            return Ok(values);
        }
    }
}
