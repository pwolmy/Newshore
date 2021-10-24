using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BL.Services;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Newshore.API.Controllers
{
    public abstract class GenericController<TEntity> : ControllerBase where TEntity: class 
    {
        private readonly ILogger<GenericController<TEntity>> _logger;
        public IMapper mapper;
        public readonly IGenericService<TEntity> _service;

       
        public GenericController(IGenericService<TEntity> service, ILogger<GenericController<TEntity>> logger)
        {
            _service = service;
            _logger = logger;
            this.mapper = Startup.MapperConfiguration.CreateMapper();
        }

        // GET: api/TEntitys
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            var entities = await _service.GetAll();
            return Ok(entities);
        }

        // GET: api/TEntitys/5
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntity>> Get(int id)
        {
            var entity = await _service.GetById(id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // PUT: api/TEntitys/5
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(int id, TEntity entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _service.Update(entity);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST: api/TEntitys
        [HttpPost]
        public virtual async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _service.Insert(entity);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }


        }

        // DELETE: api/TEntitys/5
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var entity = await _service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }

            await _service.Delete(id);

            return NoContent();
        }

    }
}
