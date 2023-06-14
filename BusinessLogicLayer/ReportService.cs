using DataAccessLayer;

namespace BusinessLogicLayer;

public class ReportService
{
    private ReportRepository _reportRepository;

    public ReportService()
    {
        _reportRepository = new ReportRepository();
    }
    
    public bool Delete(int id)
    {
        return _reportRepository.Delete(id);
    }
}