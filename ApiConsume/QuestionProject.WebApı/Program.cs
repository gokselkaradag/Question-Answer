
using QuestionProject.BusinessLayer.Abstract;
using QuestionProject.BusinessLayer.Concrete;
using QuestionProject.DataAccessLayer.Abstract;
using QuestionProject.DataAccessLayer.Concrete;
using QuestionProject.DataAccessLayer.EntityFramework;

namespace QuestionProject.WebApı
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DataContext>();

            builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();

            builder.Services.AddScoped<IQuestionDal, EfQuestionDal>();
            builder.Services.AddScoped<IQuestionService, QuestionManager>();

            // Add services to the container.
            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("QuestionApiCors", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("QuestionApiCors");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
