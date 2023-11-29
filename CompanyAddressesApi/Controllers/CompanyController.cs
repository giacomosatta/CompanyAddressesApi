using CompanyAddressesApi.Models;
using CompanyAddressesApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAddressesApi.Controllers;

[ApiController]
[Route("api/company")]
public class CompanyController : ControllerBase
{
    private readonly FileWriterService _fileWriterService;

    public CompanyController(FileWriterService fileWriterService)
    {
        _fileWriterService = fileWriterService;
    }

    [HttpPost]
    public async Task<ActionResult> PostCompanyAddress(Company company)
    {
        if (company == null)
            return BadRequest();

        try
        {
            await _fileWriterService.WriteAddress(company);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal Server Error: {ex.Message}");
        }
    }
}
