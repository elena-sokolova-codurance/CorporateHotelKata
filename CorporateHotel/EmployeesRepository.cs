namespace CorporateHotel;

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
        return _employees.FirstOrDefault(employee => employee.EmployeeId == employeeId);
    }

    public void Delete(int employeeId)
    {
        var employee = Find(employeeId);
        _employees.Remove(employee);
    }
}