using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.API.Data;
using AutoMapper;
using App.API.Models.Character;
using App.API.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace StarWars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly ICharactersRepository _charactersRepository;
        private readonly IMapper _mapper;

        public CharactersController(ICharactersRepository charactersRepository, IMapper mapper)
        {
            this._charactersRepository = charactersRepository;
            this._mapper = mapper;
        }

        // GET: api/Characters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterDto>>> GetCharacters()
        {
            var countries = await _charactersRepository.GetAllAsync();
            var records = _mapper.Map<List<CharacterDto>>(countries);

            return Ok(records);
        }

        // GET: api/Characters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterDto>> GetCharacter(int id)
        {
            var character = await _charactersRepository.GetAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            var characterDto = _mapper.Map<CharacterDto>(character);

            return Ok(characterDto);
        }

        // PUT: api/Characters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacter(int id, CharacterDto characterDto)
        {
            if (id != characterDto.Id)
            {
                return BadRequest("Invalid Record Id");
            }

            var character = await _charactersRepository.GetAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            _mapper.Map(characterDto, character);

            try
            {
                await _charactersRepository.UpdateAsync(character);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CharacterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Characters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Character>> PostCharacter(CreateCharacterDto createCharacterDto)
        {
            var character = _mapper.Map<Character>(createCharacterDto);

            await _charactersRepository.AddAsync(character);

            return CreatedAtAction("GetCharacter", new { id = character.Id }, character);
        }

        // DELETE: api/Characters/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            var character = await _charactersRepository.GetAsync(id);
            if (character == null)
            {
                return NotFound();
            }

            await _charactersRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> CharacterExists(int id)
        {
            return await _charactersRepository.Exists(id);
        }
    }
}
