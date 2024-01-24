using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using PowerATS.API.DTO;
using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoVagaController : ControllerBase
    {
        private readonly ICandidatoVagaService _candidatoVagaService;
        private readonly IMapper _mapper;

        public CandidatoVagaController(ICandidatoVagaService candidatoVagaService, IMapper mapper)
        {
            _candidatoVagaService = candidatoVagaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            { 
                var result = _mapper.Map<IEnumerable<CandidatoVagaDto>>(await _candidatoVagaService.GetAllAsync());
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

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            try
            {
                var result = _mapper.Map<CandidatoVagaDto>(await _candidatoVagaService.GetByIdAsync(id));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CandidatoVagaDto dto)
        {
            try
            {
                var entity = _mapper.Map<CandidatoVaga>(dto);
                var result = await _candidatoVagaService.CreateAsync(entity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] CandidatoVagaDto dto)
        {
            try
            {
                var exists = await _candidatoVagaService.GetByIdAsync(id);

                if (exists != null)
                {
                    var entity = _mapper.Map<CandidatoVaga>(dto);
                    var result = await _candidatoVagaService.UpdateAsync(entity);
                    return Ok(result);
                }
                else
                    return NotFound($"Item {id} não existe.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteByIdAsync(Guid id)
        {
            try
            {
                var result = await _candidatoVagaService.DeleteByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
