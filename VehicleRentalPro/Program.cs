using Microsoft.EntityFrameworkCore;
using VehicleRentalPro.CustomModelWare;
using VehicleRentalPro.Repository;
using VehicleRentalPro.Repository.Implementation;
using VehicleRentalPro.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//dbcontext configuration kismi
builder.Services.AddDbContext<CarContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("carConnection")));
//Interface ve implementasyonlarin calisma esnasinda cagirilmasi
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddAutoMapper(typeof(VehicleRepository));//NugetPackage den AutoMapper, AutoMapperDependencyInjetion kurultuktan sonra

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//VehicleRentalPro.CustomModelWare log ile hata kayitlarini yakalamak icin 
app.UseMiddleware<ExceptionHandlerMiddleware>();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
