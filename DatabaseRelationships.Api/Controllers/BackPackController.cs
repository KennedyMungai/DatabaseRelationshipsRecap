using AutoMapper;
using DatabaseRelationships.Api.Data;
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
}