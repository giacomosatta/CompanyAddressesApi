using CompanyAddressesApi.Service;

public class DTOMapperServiceTest
{
    [Fact]
    public void ShouldMapMyRequestToDto()
    {
        // Given
        var company = TestDataWriteFile.BuildCompany();

        // When
        var companyDTO = DTOMapperService.CompanyMapToDTO(company);
        var expectedDTO = TestDataWriteFile.BuildCompanyDTO();

        // Then
        Assert.Equal(expectedDTO,companyDTO);
    }
}