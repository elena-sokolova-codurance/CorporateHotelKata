using CorporateHotel;

namespace ClassLibrary.Tests;

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