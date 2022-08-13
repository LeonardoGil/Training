using Microsoft.Extensions.DependencyInjection;
using TrainingORM.Contexto;

#region ORM
using TrainingORM.Interface;
using TrainingORM.Repository;
#endregion

#region Service
using TrainingService.Interface;
using TrainingService.Service;
#endregion

namespace TrainingService.Settings
{
    public static class DependencyInjection
    {
        public static void Inject(IServiceCollection services)
        {
            services.AddScoped<TrainingContext>();

            services.InjectRepository();
            services.InjectService();
        }

        private static void InjectRepository(this IServiceCollection services)
        {
            services.AddScoped<IExerciseRepository, ExerciseRepository>();
        }

        private static void InjectService(this IServiceCollection services)
        {
            services.AddScoped<IExerciseService, ExerciseService>();
        }
    }
}
