using Christ3D.Application.Service;
using Christ3D.Application.ServiceInterface;
using Christ3D.Domain.RepositoryInterface;
using Christ3D.Infrastruct.Data.Context;
using Christ3D.Infrastruct.Data.Repository;
using Microsoft.Extensions.DependencyInjection;


namespace Christ3D.UI.Web.Extensions
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            // 注入 Application 应用层
            services.AddScoped<IStudentService, StudentService>();


            // 注入 Infra - Data 基础设施数据层
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<StudyContext>();//上下文

        }
    }
}
