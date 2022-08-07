using Microsoft.Win32;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace TrainingORM.Contexto
{
    public class TreiningDbConfiguration : DbConfiguration
    {


        public TreiningDbConfiguration()
        {
            SetDefaultConnectionFactory(GetDbConnection());
        }

        private LocalDbConnectionFactory GetDbConnection()
        {
            var registryPath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Training";
            var registryKey = "ConnectionString";

            var connectionStringObj = Registry.GetValue(registryPath, registryKey, null);
            var connectionString = connectionStringObj as string ?? throw new Exception("Não foi possivel obter a chave da ConnectionString");
            
            return new LocalDbConnectionFactory(connectionString);
        }
    }
}
