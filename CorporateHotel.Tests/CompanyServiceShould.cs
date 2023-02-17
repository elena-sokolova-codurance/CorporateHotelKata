using CorporateHotel;

namespace ClassLibrary.Tests;

public class CompanyServiceShould
{
    [Fact (DisplayName = "Add employee")]
    public void AddEmployee()
    {
        IRepository  repository = new EmployeesRepository();
        var companyService = new CompanyService(repository);

        var companyId = 1;
        var employeeId = 1;
        companyService.AddEmployee(companyId, employeeId);

        var employee = companyService.FindEmployee(employeeId);
        var expectedEmployee = new Employee(companyId, employeeId);
        Assert.True(employee.Equals(expectedEmployee));
    }
}

public class EmployeesRepository : IRepository
{
    private readonly List<Employee?> _employees = new();
    public void Add(int companyId, int employeeId)
    {
        _employees.Add(new Employee(companyId, employeeId));
    }

    public Employee? Find(int employeeId)
    {
        if (_employees.Count == 0)
            return null;
            
        return _employees[0];
    }
}