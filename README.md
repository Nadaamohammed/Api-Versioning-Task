# Api Versioning
# Endpoints After Visioning
GET /api/v1/Products
{
  "id": 1,
  "name": "Laptop",
  "price": 25000
}
```
GET /api/v2/Products
{
  "id": 1,
  "name": "Laptop",
  "price": 19.9m,
  "category": "electroncs"
}
```
# Install Package
Install-Package Asp.Versioning.Mvc
Install-Package Asp.Versioning.Mvc.ApiExplorer

# Edit Program.cs
using Asp.Versioning;

builder.Services
    .AddControllers();

builder.Services
    .AddApiVersioning(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1, 0);

        options.AssumeDefaultVersionWhenUnspecified = false;

        options.ReportApiVersions = true;

        options.ApiVersionReader =
            new UrlSegmentApiVersionReader();
    });
# Make Controller
1- ProductsV1Controller
  
2- ProductsV2Controller
# Test Endpoints
GET /api/v1/Products
GET /api/v2/Products
