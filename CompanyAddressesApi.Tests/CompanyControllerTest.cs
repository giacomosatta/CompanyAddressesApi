using CompanyAddressesApi.Controllers;
using CompanyAddressesApi.Models;
using CompanyAddressesApi.Service;
using Microsoft.AspNetCore.Mvc;
using Moq;

public class CompanyControllerTest
{

    private readonly Mock<FileWriterService> _fileWriterServiceMock;
    private readonly CompanyController _underTest;
    public CompanyControllerTest()
    {
        _fileWriterServiceMock = new Mock<FileWriterService>();
        _underTest = new CompanyController(_fileWriterServiceMock.Object);
    }

    [Fact]
    public async void ShouldReturn200()
    {
        // Given
        var company = TestDataWriteFile.BuildCompany();

        // When
        var result = await _underTest.PostCompanyAddress(company);

        // Then
        var statusCodeResult = Assert.IsType<OkResult>(result);
        Assert.Equal(200, statusCodeResult.StatusCode);
    }

    [Fact]
    public async void ShouldReturn400_WhenCompanyIsNull()
    {
        // Given
        Company company = null;

        // When
        var result = await _underTest.PostCompanyAddress(company);

        // Then
        var statusCodeResult = Assert.IsType<BadRequestResult>(result);
        Assert.Equal(400, statusCodeResult.StatusCode);
    }

}