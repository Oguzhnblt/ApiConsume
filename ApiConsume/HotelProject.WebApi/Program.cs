using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IRoom, EFRoomDal>();
builder.Services.AddScoped<IRoomService, RoomManager>();

builder.Services.AddScoped<IService, EFServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<IStaff, EFStaffDal>();
builder.Services.AddScoped<IStaffService, StaffManager>();

builder.Services.AddScoped<ISubscribe, EFSubscribeDal>();
builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

builder.Services.AddScoped<ITestimonial, EFTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
