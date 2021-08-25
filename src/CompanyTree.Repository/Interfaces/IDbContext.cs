namespace CompanyTree.Repository.Interfaces
{
    public interface IDbContext
    {
        IEmployeesRepository EmployeesRepo { get; }
        IRolesRepository RolesRepo { get; }
        ITeamsRepository TeamsRepo { get; }
    }
}
