using CompanyAddressesApi.Models;
using CompanyAddressesApi.Service;
using Xunit;

public class FileWriterServiceTest
{

    FileWriterService _underTest;

    public FileWriterServiceTest()
    {
        _underTest = new FileWriterService();
    }

    [Fact]
    public async void ShouldWriteFile()
    {
        //Arrange
        var company = TestDataWriteFile.BuildCompany();

        //Act
        var exception = await Record.ExceptionAsync(() => _underTest.WriteAddress(company));

        //Assert
        Assert.Null(exception);
    }
}