using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using PowerATS.API.DTO;
using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly ICandidatoService _candidatoService;
        private readonly IMapper _mapper;

        public CandidatoController(ICandidatoService candidatoService, IMapper mapper)
        {
            _candidatoService = candidatoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            { 
                var result = _mapper.Map<IEnumerable<CandidatoDto>>(await _candidatoService.GetAllAsync());
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

        [HttpGet("id")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            try
            {
                var result = _mapper.Map<CandidatoDto>(await _candidatoService.GetByIdAsync(id));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CandidatoDto dto)
        {
            try
            {
                var entity = _mapper.Map<Candidato>(dto);
                await _candidatoService.AddAsync(entity);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] CandidatoDto dto)
        {
            try
            {
                var exists = await _candidatoService.GetByIdAsync(id);

                if (exists != null)
                {
                    var entity = _mapper.Map<Candidato>(dto);
                    await _candidatoService.UpdateAsync(id, entity);
                    return Ok();
                }
                else
                    return NotFound($"Item {id} n�o existe.");
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
                await _candidatoService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
