namespace CorporateHotel;

public class Employee
{
    public int CompanyId;
    public int EmployeeId;

    public Employee(int companyId,int employeeId)
    {
        CompanyId = companyId;
        EmployeeId = employeeId;
    }

    public bool Equals(Employee employee)
    {
        return (EmployeeId == employee.EmployeeId && CompanyId == employee.CompanyId);
    }
    
}