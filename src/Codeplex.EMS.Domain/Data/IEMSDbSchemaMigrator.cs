using System.Threading.Tasks;

namespace Codeplex.EMS.Data;

public interface IEMSDbSchemaMigrator
{
    Task MigrateAsync();
}
