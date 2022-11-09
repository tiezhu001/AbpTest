using System.Threading.Tasks;

namespace Study.Core.Data;

public interface ICoreDbSchemaMigrator
{
    Task MigrateAsync();
}
