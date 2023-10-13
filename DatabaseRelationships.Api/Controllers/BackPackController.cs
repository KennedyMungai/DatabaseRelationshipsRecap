using DatabaseRelationships.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseRelationships.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BackPackController : ControllerBase
{
    private readonly BackPackContext _context;

    public BackPackController(BackPackContext context)
    {
        _context = context;
    }
}