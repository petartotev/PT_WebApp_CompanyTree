using CompanyTree.Common.Configuration.Interfaces;

namespace CompanyTree.Common.Configuration
{
    public class EnvironmentSettings : IDbSettings
    {
        public string ConnectionString
        {
            get
            {
                return "Server=localhost; Database=CompanyTree; Trusted_connection=true";
            }
        }
    }
}
