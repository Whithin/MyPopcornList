using System.Reflection;
using NHibernate;

namespace Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Init(args);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }

        private static WebApplicationBuilder Init(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddSingleton(factory => CreateSessionFactory(builder.Configuration));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            return builder;
        }

        private static ISessionFactory CreateSessionFactory(IConfiguration configuration)
        {
            var hibernateConfig = configuration.GetSection("HibernateConfiguration").Get<Web.Configuration.HibernateConfiguration>();
            var cfg = new NHibernate.Cfg.Configuration();

            cfg.SetProperty(NHibernate.Cfg.Environment.Dialect, hibernateConfig.SessionFactory.Dialect);
            cfg.SetProperty(NHibernate.Cfg.Environment.ConnectionString,
                hibernateConfig.SessionFactory.ConnectionString);

            var modelAssembly = Assembly.Load("Dao");
            cfg.AddAssembly(modelAssembly);

            foreach (var mapping in hibernateConfig.SessionFactory.Mappings)
            {
                cfg.AddAssembly(mapping.Assembly);
            }

            var sessionFactory = cfg.BuildSessionFactory();
            Console.WriteLine("DB");
            return sessionFactory;
        }
    }
}