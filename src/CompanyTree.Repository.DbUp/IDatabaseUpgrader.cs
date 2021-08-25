namespace CompanyTree.Repository.DbUp
{
    public interface IDatabaseUpgrader
    {
        int UpgradeDatabase(string connectionString);
    }
}
