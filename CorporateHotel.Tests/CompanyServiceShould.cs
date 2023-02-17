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
    
    [Fact (DisplayName = "Add 2 employees")]
    public void Add2Employees()
    {
        IRepository  repository = new EmployeesRepository();
        var companyService = new CompanyService(repository);

        var companyId = 1;
        var employee1Id = 1;
        companyService.AddEmployee(companyId, employee1Id);
        
        var employee2Id = 2;
        companyService.AddEmployee(companyId, employee2Id);


        var employee2 = companyService.FindEmployee(employee2Id);
        var expectedEmployee2 = new Employee(companyId, employee2Id);
        Assert.True(employee2.Equals(expectedEmployee2));
    }
    
    [Fact (DisplayName = "Delete employee")]
    public void DeleteEmployee()
    {
        IRepository  repository = new EmployeesRepository();
        var companyService = new CompanyService(repository);

        var companyId = 1;
        var employeeId = 1;
        companyService.AddEmployee(companyId, employeeId);

        companyService.DeleteEmployee(employeeId);
        
        Assert.Null(companyService.FindEmployee(employeeId));
    }
}