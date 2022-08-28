using AspectOriented.Bll.Abstract;
using AspectOriented.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspectOriented.Api.Controllers.Categories
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _service;

        /// <summary>
        /// Yapıcı
        /// </summary>
        /// <param name="employeeRepository"></param>s
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _service = categoryRepository;
        }

        [HttpGet, Route("GetAll")]
        [Produces("application/json")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return Ok(result);
        }


        [HttpPost, Route("Post")]
        [Produces("application/json")]
        public IActionResult Post([FromBody] Category val)
        {
            var result = _service.Add(val);
            if (result.Success)
                return Ok(result);
            else
                return Ok(result);
        }

        [HttpGet, Route("Delete")]
        [Produces("application/json")]
        public IActionResult Delete([FromBody] Category val)
        {
            var result = _service.Delete(val);
            if (result.Success)
                return Ok(result);
            else
                return Ok(result);
        }

    }
}
