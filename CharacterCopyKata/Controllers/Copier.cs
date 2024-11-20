using CharacterCopyKata.Core;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CopierController : ControllerBase
{
    private readonly Copier _copier;

    public CopierController(Copier copier)
    {
        _copier = copier;
    }

    [HttpPost("copy")]
    public IActionResult Copy()
    {
        try
        {
            _copier.Copy();
            return Ok("Copy operation completed successfully!");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred during the copy operation: {ex.Message}");
        }
    }

    [HttpPost("copy-multiple/{count}")]
    public IActionResult CopyMultiple(int count)
    {
        try
        {
            _copier.CopyMultiple(count);
            return Ok($"Copied {count} characters successfully!");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred during the multiple copy operation: {ex.Message}");
        }
    }
}
