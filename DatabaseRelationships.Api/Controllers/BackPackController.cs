using AutoMapper;
using DatabaseRelationships.Api.Data;
using DatabaseRelationships.Api.Models;
using DatabaseRelationships.Api.Models.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseRelationships.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BackPackController : ControllerBase
{
    private readonly BackPackContext _context;
    private readonly IMapper _mapper;

    public BackPackController(BackPackContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<List<Character>>> CreateCharacter(CharacterCreateDTO character)
    {
        if (!ModelState.IsValid)
        {
            return await Task.FromResult(BadRequest(ModelState));
        }

        await _context.Characters.AddAsync(_mapper.Map<Character>(character));

        await _context.SaveChangesAsync();

        return await Task.FromResult(CreatedAtRoute("RetrieveOneCharacter", new { Id = _mapper.Map<Character>(character).Id }, character));
    }
}