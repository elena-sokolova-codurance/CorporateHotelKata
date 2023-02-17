using CorporateHotel;

namespace ClassLibrary.Tests;

public class EmployeesRepository : IRepository
{
    private readonly List<Employee?> _employees = new();
    public void Add(int companyId, int employeeId)
    {
        if (Find(employeeId) != null)
        {
            throw new Exception("Employee is already exist");
        }
        _employees.Add(new Employee(companyId, employeeId));
    }

    public Employee? Find(int employeeId)
    {
        foreach (var employee in _employees.Where(employee => employee.EmployeeId == employeeId))
        {
            return employee;
        }

        return null;
    }

    public void Delete(int employeeId)
    {
        var employee = Find(employeeId);
        _employees.Remove(employee);
    }
}