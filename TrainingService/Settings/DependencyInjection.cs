using Microsoft.Extensions.DependencyInjection;
using TrainingORM.Contexto;

#region ORM
using TrainingORM.Interface;
using TrainingORM.Repository;
#endregion

#region Service
using TrainingService.Interface;
using TrainingService.Service.Register;
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
            services.AddScoped<ITrainingRepository, TrainingRepository>();
            services.AddScoped<ITrainingExerciseRepository, TrainingExerciseRepository>();
            services.AddScoped<IExerciseSeriesRepository, ExerciseSeriesRepository>();
        }

        private static void InjectService(this IServiceCollection services)
        {
            services.AddScoped<IExerciseRegisterService, ExerciseRegisterService>();
            services.AddScoped<ITrainingRegisterService, TrainingRegisterService>();
        }
    }
}
