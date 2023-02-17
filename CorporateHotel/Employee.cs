namespace CorporateHotel;

public class Employee
{
    private readonly int _companyId;
    public readonly int EmployeeId;

    public Employee(int companyId,int employeeId)
    {
        _companyId = companyId;
        EmployeeId = employeeId;
    }

    public bool Equals(Employee employee)
    {
        return (EmployeeId == employee.EmployeeId && _companyId == employee._companyId);
    }
    
}