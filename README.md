# Domain-Driven-Design
Domain-Driven Design (DDD) là một phương pháp thiết kế phần mềm tập trung vào việc mô hình hóa và làm việc với các vấn đề kinh doanh phức tạp thông qua việc sử dụng ngôn ngữ chung (Ubiquitous Language) và mô hình miền (domain models). DDD giúp kết nối sâu sắc giữa các nhà phát triển và chuyên gia lĩnh vực (domain experts).

### Các khái niệm cơ bản trong DDD
1. Entity (Thực thể): Đối tượng có định danh duy nhất (unique identity) và vòng đời riêng.
2. Value Object (Đối tượng giá trị): Đối tượng không có định danh, chỉ quan tâm đến thuộc tính.
3. Aggregate (Tập hợp): Một cụm các thực thể và đối tượng giá trị được xử lý như một đơn vị nhất quán duy nhất.
4. Repository (Kho lưu trữ): Thành phần chịu trách nhiệm truy xuất và lưu trữ các tập hợp.
5. Service (Dịch vụ): Chứa logic nghiệp vụ mà không tự nhiên thuộc về bất kỳ thực thể hay đối tượng giá trị nào.
6. Domain Event (Sự kiện miền): Sự kiện quan trọng xảy ra trong miền nghiệp vụ.
7. Factory (Nhà máy): Thành phần chịu trách nhiệm tạo ra các thực thể và đối tượng giá trị phức tạp.

### Cấu trúc Thư mục
Cấu trúc thư mục của một dự án Domain-Driven Design (DDD) thường được tổ chức theo cách giúp tách biệt rõ ràng các phần của miền nghiệp vụ (domain), ứng dụng (application), cơ sở hạ tầng (infrastructure), và các giao diện người dùng hoặc API (interfaces). 

```
MyDDDProject/
├── src/
│   ├── MyDDDProject.Domain/
│   │   ├── Entities/
│   │   │   ├── Order.cs
│   │   │   ├── OrderItem.cs
│   │   │   ├── Product.cs
│   │   ├── Events/
│   │   │   ├── OrderCreatedEvent.cs
│   │   ├── Repositories/
│   │   │   ├── IOrderRepository.cs
│   │   ├── Services/
│   │   │   ├── OrderService.cs
│   │   ├── Aggregates/
│   │   │   ├── OrderAggregate.cs
│   │   ├── ValueObjects/
│   │   │   ├── Price.cs (ví dụ thêm nếu có đối tượng giá trị phức tạp)
│   │   └── Specifications/ (nếu có)
│
│   ├── MyDDDProject.Infrastructure/
│   │   ├── Repositories/
│   │   │   ├── OrderRepository.cs
│   │   ├── EventStore/ (nếu có sử dụng)
│   │   ├── Persistence/ (các thành phần liên quan đến lưu trữ như context của EF)
│   │   │   ├── DbContext.cs
│   │   └── Services/ (nếu có các dịch vụ cơ sở hạ tầng như email, logging)
│
│   ├── MyDDDProject.Application/
│   │   ├── Commands/
│   │   │   ├── CreateOrderCommand.cs
│   │   │   ├── AddOrderItemCommand.cs
│   │   ├── DTOs/
│   │   │   ├── OrderDto.cs
│   │   ├── Handlers/
│   │   │   ├── CreateOrderCommandHandler.cs
│   │   │   ├── AddOrderItemCommandHandler.cs
│   │   ├── Queries/
│   │   │   ├── GetOrderByIdQuery.cs
│   │   ├── Services/ (các dịch vụ ứng dụng, nếu cần)
│   │   └── Interfaces/ (các giao diện cho dịch vụ ứng dụng)
│
│   ├── MyDDDProject.API/
│   │   ├── Controllers/
│   │   │   ├── OrdersController.cs
│   │   ├── Models/
│   │   │   ├── OrderModel.cs
│   │   ├── ViewModels/
│   │   ├── DTOs/ (nếu có các DTO riêng cho API)
│   │   ├── Mappings/ (các cấu hình AutoMapper nếu cần)
│   │   └── Startup.cs
│
├── tests/
│   ├── MyDDDProject.Domain.Tests/
│   ├── MyDDDProject.Infrastructure.Tests/
│   ├── MyDDDProject.Application.Tests/
│   ├── MyDDDProject.API.Tests/
│
└── README.md
```
```
## src: Thư mục chính chứa mã nguồn của ứng dụng.

 - MyDDDProject.Domain: Chứa tất cả các thành phần liên quan đến miền nghiệp vụ.
    + Entities: Chứa các thực thể (entity) của miền.
    + Events: Chứa các sự kiện miền (domain events).
    + Repositories: Chứa các giao diện kho lưu trữ (repository interfaces).
    + Services: Chứa các dịch vụ miền (domain services).
    + Aggregates: Chứa các tập hợp (aggregates).
    + ValueObjects: Chứa các đối tượng giá trị (value objects).
    + Specifications: Chứa các đặc tả miền (domain specifications), nếu có.

- MyDDDProject.Infrastructure: Chứa tất cả các thành phần cơ sở hạ tầng.
    + Repositories: Chứa các triển khai kho lưu trữ (repository implementations).
    + EventStore: Chứa các thành phần liên quan đến lưu trữ sự kiện, nếu sử dụng Event Sourcing.
    + Persistence: Chứa các thành phần liên quan đến lưu trữ dữ liệu (như DbContext trong Entity Framework).
    + Services: Chứa các dịch vụ cơ sở hạ tầng khác (như email, logging).

- MyDDDProject.Application: Chứa các thành phần liên quan đến ứng dụng.
    + Commands: Chứa các lệnh (commands).
    + DTOs: Chứa các đối tượng truyền dữ liệu (data transfer objects).
    + Handlers: Chứa các bộ xử lý lệnh (command handlers).
    + Queries: Chứa các truy vấn (queries).
    + Services: Chứa các dịch vụ ứng dụng (application services), nếu cần.
    + Interfaces: Chứa các giao diện cho các dịch vụ ứng dụng.

- MyDDDProject.API: Chứa các thành phần liên quan đến giao diện người dùng hoặc API.
    + Controllers: Chứa các bộ điều khiển (controllers).
    + Models: Chứa các mô hình (models).
    + ViewModels: Chứa các mô hình giao diện (view models).
    + DTOs: Chứa các đối tượng truyền dữ liệu riêng cho API.
    + Mappings: Chứa các cấu hình AutoMapper, nếu cần.
    + Startup.cs: Cấu hình ứng dụng.

- tests: Thư mục chứa các dự án kiểm thử (test projects).
    + MyDDDProject.Domain.Tests: Kiểm thử các thành phần miền.
    + MyDDDProject.Infrastructure.Tests: Kiểm thử các thành phần cơ sở hạ tầng.
    + MyDDDProject.Application.Tests: Kiểm thử các thành phần ứng dụng.
    + MyDDDProject.API.Tests: Kiểm thử các thành phần API.

- README.md: Tệp tài liệu hướng dẫn và mô tả dự án.
```
Cấu trúc này cung cấp một nền tảng mạnh mẽ và có tổ chức cho việc phát triển phần mềm dựa trên nguyên tắc DDD. Mỗi lớp và thư mục đều phục vụ một mục đích rõ ràng, giúp việc quản lý mã nguồn trở nên dễ dàng hơn và đảm bảo rằng dự án có thể mở rộng và bảo trì một cách hiệu quả.

## Visual Studio
## Tạo Solution và các Project
1. Mở Visual Studio và chọn Create a new project.
2. Chọn Blank Solution và nhấn Next.
3. Đặt tên cho Solution (ví dụ: MyDDDProject) và chọn vị trí lưu trữ, sau đó nhấn Create.

## Tạo các Project con
1. Tạo Project Domain:
   - Nhấp chuột phải vào Solution, chọn Add > New Project.
   - Chọn Class Library (.NET Core), đặt tên là MyDDDProject.Domain, và nhấn Create.

2. Tạo Project Infrastructure:
   - Nhấp chuột phải vào Solution, chọn Add > New Project.
   - Chọn Class Library (.NET Core), đặt tên là MyDDDProject.Infrastructure, và nhấn Create
   - 
3. Tạo Project Application:
   - Nhấp chuột phải vào Solution, chọn Add > New Project.
   - Chọn Class Library (.NET Core), đặt tên là MyDDDProject.Application, và nhấn Create.
   - 
4. Tạo Project API:
   - Nhấp chuột phải vào Solution, chọn Add > New Project.
   - Chọn ASP.NET Core Web Application.
   - Đặt tên là MyDDDProject.API, chọn API template, và nhấn Create.

## Thêm các Project Test
 - Chọn xUnit Test Project (.NET Core) cho các Project Test

## Thêm các gói NuGet cần thiết
```
Ví dụ:
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection
Install-Package MediatR
Install-Package xunit
Install-Package Moq
...
```

## Cấu hình Dependency Injection trong Startup.cs
```
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
        services.AddAutoMapper(typeof(Startup));
        
        // Register services and repositories
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IOrderApplicationService, OrderApplicationService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
```
# Cấu hình dự án khởi chạy
- Bước 1: Cấu hình Project
  - Trong cửa sổ Startup Project, chọn Multiple startup projects.
  - Đặt hành động cho dự án API (MyDDDProject.API) là Start.
  - Nhấn OK để lưu cấu hình.

- Bước 2:  Cấu hình Dependency Injection (DI) trong Startup.cs
```
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
        services.AddAutoMapper(typeof(Startup));
        
        // Register services and repositories
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IOrderApplicationService, OrderApplicationService>();
        
        // Add EF Core context
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        // Add MediatR
        services.AddMediatR(typeof(Startup));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
```
- Bước 3: Thiết lập kết nối cơ sở dữ liệu
  
  Cập nhật appsettings.json trong dự án API để cấu hình chuỗi kết nối cơ sở dữ liệu.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MyDDDProjectDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```
- Bước 4: Tạo Migration và cập nhật cơ sở dữ liệu

  ```
  Add-Migration InitialCreate -Project MyDDDProject.Infrastructure -StartupProject MyDDDProject.API
  Update-Database -Project MyDDDProject.Infrastructure -StartupProject MyDDDProject.API
  ```

- Bước 5: Chạy chương trình
   - Nhấn F5 hoặc Ctrl+F5 trong Visual Studio để chạy dự án.
   - Trình duyệt mặc định sẽ mở ra và truy cập vào API của bạn. Bạn có thể thử nghiệm các endpoint API như /api/orders/{id}.

- Bước 6: Kiểm tra các Endpoint API
     - Thêm Swagger vào Startup.cs trong phương thức ConfigureServices:
  ```
  public void ConfigureServices(IServiceCollection services)
  {
    services.AddControllers();
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyDDDProject.API", Version = "v1" });
    });
    services.AddAutoMapper(typeof(Startup));
    services.AddScoped<IOrderRepository, OrderRepository>();
    services.AddScoped<IOrderApplicationService, OrderApplicationService>();
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddMediatR(typeof(Startup));
  }

  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyDDDProject.API v1"));
    }

    app.UseHttpsRedirection();
    app.UseRouting();
    app.UseAuthorization();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
  }
  ```
Khi chạy ứng dụng, bạn có thể truy cập Swagger UI tại https://localhost:5001/swagger để xem và kiểm tra các endpoint API.

- Bước 7:  Viết và chạy Unit Test (Solution Explorer -> Run Tests.)
   Tạo Migration và cập nhật cơ sở dữ liệu (nếu cần):
  ```
  Ví dụ:
  Enable-Migrations -ProjectName MyDDDProject.Infrastructure
  Add-Migration InitialCreate -ProjectName MyDDDProject.Infrastructure
  Update-Database -ProjectName MyDDDProject.Infrastructure
  ...
  ```
