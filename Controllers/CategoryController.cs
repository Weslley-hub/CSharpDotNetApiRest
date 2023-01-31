using Microsoft.AspNetCore.Mvc;
using Dws.Note_one.Api.Domain.Models;
using Dws.Note_one.Api.Domain.Services.IServices;

namespace Dws.Note_one.Api.Cotrollers {
    [Route("/api/[controller]")]

    public class CategoryController : Controller
    {
        private readonly ICategoryService _categpryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categpryService = categoryService;
        }

        [HttpGet]

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}