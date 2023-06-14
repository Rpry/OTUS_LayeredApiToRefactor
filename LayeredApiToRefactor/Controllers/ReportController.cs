using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;

namespace LayeredApiToRefactor.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{
    private ReportService _reportService; 
    
    public ReportController(ReportService reportService)
    {
        _reportService = reportService;
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        _reportService.Delete(id);
        return Ok();
    }
}