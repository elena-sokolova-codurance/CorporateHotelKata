namespace CorporateHotel;

public interface IRepository
{
    public void Add(int companyId, int employeeId);
    public Employee? Find(int employeeId);
    public void Delete(int employeeId);
}