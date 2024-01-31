using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using PowerATS.API.DTO;
using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagaController : ControllerBase
    {
        private readonly IVagaService _vagaService;
        private readonly IMapper _mapper;

        public VagaController(IVagaService vagaService, IMapper mapper)
        {
            _vagaService = vagaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var result = _mapper.Map<IEnumerable<VagaDto>>(await _vagaService.GetAllAsync());
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
                var result = _mapper.Map<VagaDto>(await _vagaService.GetByIdAsync(id));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] VagaDto dto)
        {
            try
            {
                var entity = _mapper.Map<Vaga>(dto);
                await _vagaService.AddAsync(entity);

                var entityAdd = await _vagaService.GetByIdAsync(entity.Id);

                return Ok(entityAdd);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] VagaDto dto)
        {
            try
            {
                var exists = await _vagaService.GetByIdAsync(id);

                if (exists != null)
                {
                    var entity = _mapper.Map<Vaga>(dto);
                    await _vagaService.UpdateAsync(id, entity);
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
                await _vagaService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
