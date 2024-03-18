using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ArtworkController : ControllerBase
{
    private readonly ILogger<ArtworkController> _logger;
    private readonly AppDbContext _context;
    public ArtworkController(ILogger<ArtworkController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }
     
    
    
}