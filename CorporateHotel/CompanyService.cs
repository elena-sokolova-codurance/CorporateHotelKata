namespace CorporateHotel;

public class CompanyService
{
    private readonly IRepository _employeesRepository;
    public CompanyService(IRepository employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }

    public void AddEmployee(int companyId, int employeeId)
    {
        _employeesRepository.Add(companyId, employeeId);
    }

    public Employee? FindEmployee(int employeeId)
    {
        return _employeesRepository.Find(employeeId);
    }

    public void DeleteEmployee(int employeeId)
    {
        _employeesRepository.Delete(employeeId);
    }
}