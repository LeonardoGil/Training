using Microsoft.Win32;
using System.Data.Entity;
using TrainingLibrary.Entity;

namespace TrainingORM.Contexto
{
    public class TrainingContext : DbContext
    {
        private static string connectionString()
        {
            var registryPath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Training";
            var registryKey = "ConnectionString";

            var connectionStringObj = Registry.GetValue(registryPath, registryKey, null);
            var connectionString = connectionStringObj as string ?? throw new Exception("Não foi possivel obter a chave da ConnectionString");

            return connectionString;
        }


        public TrainingContext() : base(connectionString())
        {
        }

        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<ExerciseSeries> ExerciseSeries { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<TrainingExercise> TrainingExercise { get; set; }
    }
}
