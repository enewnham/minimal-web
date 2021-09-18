namespace Api;

using Microsoft.OpenApi.Models;

public class Startup
{
	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	public IConfiguration Configuration { get; }

	public void ConfigureServices(IServiceCollection services)
	{
		services.AddControllers();
		services.AddSwaggerGen(c =>
		{
			c.SwaggerDoc("v1", new() { Title = "api", Version = "v1" });
		});
	}

	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	{
		if (env.IsDevelopment())
		{
			app.UseDeveloperExceptionPage();
		}
		else
		{
			app.UseHsts();
		}

		app.UseSwagger();
		app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "api v1"));

		app.UseHttpsRedirection();

		app.UseRouting();

		app.UseAuthorization();

		app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
	}
}