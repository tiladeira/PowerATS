using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using PowerATS.API.DTO;
using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculoController : ControllerBase
    {
        private readonly ICurriculoService _curriculoService;
        private readonly IMapper _mapper;

        public CurriculoController(ICurriculoService curriculoService, IMapper mapper)
        {
            _curriculoService = curriculoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            { 
                var result = _mapper.Map<IEnumerable<CurriculoDto>>(await _curriculoService.GetAllAsync());
                return Ok(new
                {
                    items = result,
                    hasNext = false
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            try
            {
                var result = _mapper.Map<CurriculoDto>(await _curriculoService.GetByIdAsync(id));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CurriculoDto dto)
        {
            try
            {
                var entity = _mapper.Map<Curriculo>(dto);
                await _curriculoService.AddAsync(entity);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] CurriculoDto dto)
        {
            try
            {
                var exists = await _curriculoService.GetByIdAsync(id);

                if (exists != null)
                {
                    var entity = _mapper.Map<Curriculo>(dto);
                    await _curriculoService.UpdateAsync(id, entity);
                    return Ok();
                }
                else
                    return NotFound($"Item {id} não existe.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteByIdAsync(string id)
        {
            try
            {
                await _curriculoService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
