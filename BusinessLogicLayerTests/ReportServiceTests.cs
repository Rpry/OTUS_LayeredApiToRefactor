using BusinessLogicLayer;
using DataAccessLayer;
using Moq;
using Xunit;

namespace BusinessLogicLayerTests;


public class ReportServiceTests
{
    private ReportService _reportService; 
    public ReportServiceTests()
    {
        _reportService = new ReportService();
    }
    
    [Fact]
    public void Test()
    {
        //Arrange
        int id = 1;
        
        //Act
        var result = _reportService.Delete(id);

        //Assert
        Assert.True(result);
    }
}