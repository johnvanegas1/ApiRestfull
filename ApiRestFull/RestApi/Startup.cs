using Microsoft.OpenApi.Models;
using RepositoriesEFCore;

namespace RestApi
{
    public class Startup
    {
        readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "ApiRest.Api",
                    Version = "v1"
                });
            });
            services.AddRepositories(this.configuration);
        }


    }
}
